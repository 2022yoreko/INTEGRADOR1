﻿using System;

namespace APPCOMY
{
    internal class StreamWriter
    {
        private FileStream fs;

        public StreamWriter(FileStream fs)
        {
            this.fs = fs;
        }

        public StreamWriter()
        {
        }

        internal void WriteLine(object text)
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}