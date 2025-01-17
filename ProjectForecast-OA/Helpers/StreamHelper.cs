﻿namespace StoryDemo.Helpers
{
    using System.IO;

    public static class StreamHelper
    {
        public static byte[] ReadFully(this Stream input, byte[] buffer = null)
        {
            buffer = buffer ?? new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
    }
}