using Newtonsoft.Json;
using SharpVk.Generator.Collation;
using System.Collections.Generic;
using System.IO;

namespace SharpVk.Generator.Generation
{
    public class CommentGenerator
    {
        private const string commentCacheFilePath = ".\\CommentCache.json";

        private readonly SortedDictionary<string, string> commentInfo;

        public CommentGenerator(Dictionary<string, TypeDeclaration> typeData, IEnumerable<EnumDeclaration> enums, IEnumerable<CommandDeclaration> commands)
        {
            this.commentInfo = new SortedDictionary<string, string>();

            void TryAdd(string key)
            {
                if (!commentInfo.ContainsKey(key))
                {
                    commentInfo.Add(key, "");
                }
            }

            foreach (var typeItem in typeData)
            {
                TryAdd(typeItem.Key);

                foreach (var typeMember in typeItem.Value.Members)
                {
                    TryAdd($"{typeItem.Key}.{typeMember.VkName}");
                }
            }

            foreach (var @enum in enums)
            {
                foreach (var enumField in @enum.Fields)
                {
                    TryAdd($"{@enum.VkName}.{enumField.VkName}");
                }
            }

            foreach (var command in commands)
            {
                TryAdd(command.VkName);

                foreach (var commandParam in command.Params)
                {
                    TryAdd($"{command.VkName}.{commandParam.VkName}");
                }
            }

            void TrySet(string key, string comment)
            {
                if (commentInfo.ContainsKey(key))
                {
                    commentInfo[key] = comment;
                }
            }

            if (File.Exists(commentCacheFilePath))
            {
                var fileContents = File.ReadAllText(commentCacheFilePath);

                foreach (var entry in JsonConvert.DeserializeObject<Dictionary<string, string>>(fileContents))
                {
                    TrySet(entry.Key, entry.Value);
                }
            }
            
            File.WriteAllText(commentCacheFilePath, JsonConvert.SerializeObject(commentInfo, Formatting.Indented));
        }

        public string Lookup(string name)
        {
            return this.commentInfo[name];
        }
    }
}