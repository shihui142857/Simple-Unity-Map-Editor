﻿using UnityEngine;
using System.Collections;

namespace MapEditor
{
	public class WalkableTile : Deployable
	{
		public override DeployableType GetDeployableType()
		{
			return DeployableType._Walkable;
		}
	}
}