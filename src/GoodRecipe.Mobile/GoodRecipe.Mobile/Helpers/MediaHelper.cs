using System.IO;

namespace GoodRecipe.Mobile.Helpers
{
    public static class MediaHelper
    {
        public static byte[] ToByteArray(this Stream inputStream)
        {
            byte[] bytes = new byte[inputStream.Length];
            using (MemoryStream memoryStream = new MemoryStream())
            {
                int count;
                while ((count = inputStream.Read(bytes, 0, bytes.Length)) > 0)
                {
                    memoryStream.Write(bytes, 0, count);
                }
                return memoryStream.ToArray();
            }
        }
    }
}
