using System;
using UnityEngine;
using MelonLoader;

namespace TP2MouseML
{
	public class TP2MouseML : MelonMod
	{
        public static class BuildInfo
        {
            public const string CompatibleGame = "VRChat";
            public const string Name = "TP2MouseML";
            public const string Description = null;
            public const string Author = "CJ";
            public const string Company = null;
            public const string Version = "1.0.0";
            public const string DownloadLink = null;
        }

        public override void OnApplicationStart()
		{
            MelonModLogger.Log(ConsoleColor.Cyan, "==============================================");
            MelonModLogger.Log(ConsoleColor.Green, "TP2Mouse by CJ [Loaded!]");
            MelonModLogger.Log(ConsoleColor.Green, "Press T to teleport to your crosshair!");
            MelonModLogger.Log(ConsoleColor.Cyan, "==============================================");
		}

        public override void OnGUI()
        {
        }

		public override void OnUpdate()
		{
            if (Input.GetKeyDown(KeyCode.T))
			{
                RayTeleport();
            }
        }

        public static void RayTeleport()
        {
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

            RaycastHit[] hits = Physics.RaycastAll(ray);
            if (hits.Length > 0)
            {
                RaycastHit raycastHit = hits[0];
                VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position = raycastHit.point;
            }
        }
    }
}
