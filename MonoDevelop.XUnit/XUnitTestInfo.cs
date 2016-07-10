//
// XUnitTestInfo.cs
//
// Author:
//       Sergey Khabibullin <sergey@khabibullin.com>
//
// Copyright (c) 2014 Sergey Khabibullin
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using MonoDevelop.Core.Execution;

namespace MonoDevelop.XUnit
{
	/// <summary>
	/// xunit test info.
	/// </summary>
	/// <remarks>
	/// It is serializable because it goes through process boundary.
	/// </remarks>
	[MessageDataType]
	[Serializable]
	public class XUnitTestInfo
	{
		[MessageDataProperty]
		public string Id { get; set; }
		[MessageDataProperty]
		public string Name{ get; set; }
		[MessageDataProperty]
		public string Type{ get; set; }
		[MessageDataProperty]
		public string Method{ get; set; }
		[MessageDataProperty]
		public XUnitTestInfo[] Tests{ get; set; }
		[MessageDataProperty]
		public object[] Args{ get; set; }
	}
}
