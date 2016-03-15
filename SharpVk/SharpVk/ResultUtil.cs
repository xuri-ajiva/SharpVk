using System;

namespace SharpVk
{
    public static class ResultUtil
    {
        public static void HandleResult(Result vkResult)
        {
            if ((int)vkResult < 0)
            {
                throw new Exception("Function returned error result: " + vkResult);
            }
        }
    }
}
