﻿// --------------------------------------------------------------------------------
// Copyright (c) J.D. Purcell
//
// Licensed under the MIT License (see LICENSE.txt)
// --------------------------------------------------------------------------------
using System;

namespace RechatTool {
	public static class Extensions {
		public static string NullIfEmpty(this string s) {
			return String.IsNullOrEmpty(s) ? null : s;
		}
	}
}