﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
#if !NET35
using System.Collections;
using System.Collections.Generic;

namespace System.Text.Utf8
{
    partial struct Utf8String
    {
        public struct CodePointEnumerable : IEnumerable<UnicodeCodePoint>, IEnumerable
        {
            private Span<byte> _buffer;

            public CodePointEnumerable(byte[] bytes, int index, int length)
            {
                _buffer = new Span<byte>(bytes, index, length);
            }

            public unsafe CodePointEnumerable(Span<byte> buffer)
            {
                _buffer = buffer;
            }

            public CodePointEnumerator GetEnumerator()
            {
                return new CodePointEnumerator(_buffer);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            IEnumerator<UnicodeCodePoint> IEnumerable<UnicodeCodePoint>.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
#endif