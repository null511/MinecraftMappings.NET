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
                    element.Translate = new Vector3(0f, -2f, -5.5f);
                    element.RotationAngleY = -180;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-9f, 3f, 23.5f),
                        Size = new Vector3(18f, 6f, 2f),
                        UV = new Vector2(0f, 19f),
                    });

                    element.Submodels = new List<EntityElement> {
                        new EntityElement {
                            Name = "front2",
                            Translate = new Vector3(0f, 6f, -5f),
                            RotationAngleY = -180,

                            Cubes = {
                                new EntityElementCube {
                                    Position = new Vector3(-8f, -3f, -0.5f),
                                    Size = new Vector3(16f, 6f, 2f),
                                    UV = new Vector2(0f, 27f),
                                },
                            },
                        },
                        new EntityElement {
                            Name = "sides",
                            Translate = new Vector3(15f, -22f, -5f),
                            RotationAngleY = 90,

                            Cubes = {
                                new EntityElementCube {
                                    Position = new Vector3(-28.5f, 25f, -7f),
                                    Size = new Vector3(28f, 6f, 2f),
                                    UV = new Vector2(0f, 35f),
                                },
                            },

                            Submodels = new List<EntityElement> {
                                new EntityElement {
                                    Name = "sides2",
                                    Translate = new Vector3(-15f, 28f, -24f),
                                    RotationAngleY = -180,

                                    Cubes = {
                                        new EntityElementCube {
                                            Position = new Vector3(-14.5f, -3f, -1f),
                                            Size = new Vector3(28f, 6f, 2f),
                                            UV = new Vector2(0f, 43f),
                                        },
                                    },
                                },
                            },
                        },
                        new EntityElement {
                            Name = "base",
                            Translate = new Vector3(0f, 2f, 10f),
                            RotationAngleX = -90,
                            RotationAngleY = -90,

                            Cubes = {
                                new EntityElementCube {
                                    Position = new Vector3(-14.5f, -8f, -2f),
                                    Size = new Vector3(28f, 16f, 3f),
                                    UV = new Vector2(0f, 0f),
                                },
                            },
                        },
                    };
                })
                .AddElement("paddle_left", element => {
                    element.Translate = new Vector3(-13.5f, -6f, 4f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(12.5f, 4f, -9f),
                        Size = new Vector3(2f, 2f, 18f),
                        UV = new Vector2(62f, 0f),
                    });
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(13.51f, 3f, 4f),
                        Size = new Vector3(1f, 6f, 7f),
                        UV = new Vector2(62f, 0f),
                    });
                })
                .AddElement("paddle_right", element => {
                    element.Translate = new Vector3(13.5f, -6f, 4f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-14.5f, 4f, -9f),
                        Size = new Vector3(2f, 2f, 18f),
                        UV = new Vector2(62f, 20f),
                    });
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-14.51f, 3f, 4f),
                        Size = new Vector3(1f, 6f, 7f),
                        UV = new Vector2(62f, 20f),
                    });
                });
        }
    }
}
