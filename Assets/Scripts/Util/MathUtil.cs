﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flocking.Util
{
	public static class MathUtil
	{
		public static Vector3 FindAveragePosition(Component[] components)
		{
			Vector3 average = Vector3.zero;
			for (int i = 0; i < components.Length; ++i) {
				average += components[i].transform.position;
			}

			return average / components.Length;
		}
	}
}