﻿using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class SlimeFull : JavaEntityModel
    {
        public SlimeFull() : base("Slime Full")
        {
            AddVersion("slime_full", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("body", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 1f, -3f),
                        Size = new Vector3(6f, 6f, 6f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("right_eye", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3.3f, 4f, -3.5f),
                        Size = new Vector3(2f, 2f, 2f),
                        UV = new Vector2(32f, 0f),
                    });
                })
                .AddElement("left_eye", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1.3f, 4f, -3.5f),
                        Size = new Vector3(2f, 2f, 2f),
                        UV = new Vector2(32f, 4f),
                    });
                })
                .AddElement("mouth", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 2f, -3.5f),
                        Size = new Vector3(1f, 1f, 1f),
                        UV = new Vector2(32f, 8f),
                    });
                })
                .AddElement("gel", element => {
                    element.Translate = new Vector3(0f, -4f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 0f, -4f),
                        Size = new Vector3(8f, 8f, 8f),
                    });
                });
        }
    }
}
