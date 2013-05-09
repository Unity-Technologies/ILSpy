using System;
using System.Runtime.CompilerServices;

namespace ICSharpCode.Decompiler.Tests
{
	internal class UnsafeCodeBug
	{
		private char start_char;
		private int length = 100;

		[IndexerName("Chars")]
		public unsafe char this[int index]
		{
			get
			{
				if (index < 0 || index >= length)
					throw new IndexOutOfRangeException();
				fixed (char* c = &start_char)
					return c[index];
			}
		}

		
		


	}
}
