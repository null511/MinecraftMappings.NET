﻿using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Bamboo4_Age0 : JavaBlockModel
    {
        public Bamboo4_Age0() : base("Bamboo 4, Age 0")
        {
            AddVersion("bamboo4_age0", "1.14")
                .WithPath("models/block")
                .AddTexture("all", "block/bamboo_stalk")
                .AddElement(element => {
                    element.From = new Vector3(7f, 0f, 7f);
                    element.To = new Vector3(9f, 16f, 9f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(13f, 0f, 15f, 2f),
                        Texture = "#all",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(13f, 4f, 15f, 6f),
                        Texture = "#all",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(9f, 0f, 11f, 16f),
                        Texture = "#all",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(9f, 0f, 11f, 16f),
                        Texture = "#all",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(9f, 0f, 11f, 16f),
                        Texture = "#all",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(9f, 0f, 11f, 16f),
                        Texture = "#all",
                    };
                });
        }
    }
}
