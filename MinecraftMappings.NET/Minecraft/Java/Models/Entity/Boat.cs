using MinecraftMappings.Internal.Models.Entity;
using SharpDX;
using System.Collections.Generic;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Boat : JavaEntityModel
    {
        public Boat() : base("Boat")
        {
            AddVersion("boat", "1.0.0")
                .WithTextureSize(128, 64)
                .AddElement("front", element => {
                    element.Position = new Vector3(-9f, 3f, 23.5f);
                    element.Size = new Vector3(18f, 6f, 2f);
                    element.UV = new Vector2(0f, 19f);
                    element.RotationOrigin = new Vector3(0f, -2f, -5.5f);
                    element.RotationAngleY = 180;

                    element.Elements = new List<EntityElement> {
                        new EntityElement {
                            Name = "back",
                            Position = new Vector3(-8f, -3f, -0.5f),
                            Size = new Vector3(16f, 6f, 2f),
                            UV = new Vector2(0f, 27f),
                            RotationOrigin = new Vector3(0f, 6f, -5f),
                            RotationAngleY = 180,
                        },
                        new EntityElement {
                            Name = "left",
                            Position = new Vector3(-13.5f, 3f, -12f),
                            Size = new Vector3(28f, 6f, 2f),
                            UV = new Vector2(0f, 35f),
                            RotationOrigin = new Vector3(15f, -22f, -5f),
                            RotationAngleY = 90,

                            Elements = new List<EntityElement> {
                                new EntityElement {
                                    Name = "right",
                                    Position = new Vector3(-14.5f, 3f, -30f),
                                    Size = new Vector3(28f, 6f, 2f),
                                    UV = new Vector2(0f, 43f),
                                    RotationOrigin = new Vector3(0f, 6f, -29f),
                                    RotationAngleY = 180,
                                },
                            },
                        },
                        new EntityElement {
                            Name = "base",
                            Position = new Vector3(-14.5f, -6f, 8f),
                            Size = new Vector3(28f, 16f, 3f),
                            UV = new Vector2(0f, 0f),
                            RotationOrigin = new Vector3(0f, 2f, 10f),
                            RotationAngleX = 270,
                            RotationAngleY = 270,
                        },
                    };
                });
        }
    }
}
