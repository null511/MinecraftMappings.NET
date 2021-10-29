using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Squid : JavaEntityModel
    {
        public Squid() : base("Squid")
        {
            AddVersion("squid", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("body", element => {
                    element.Translate = new Vector3(0f, -25f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 17f, -6f),
                        Size = new Vector3(12f, 16f, 12f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("tentacle1", element => {
                    element.Translate = new Vector3(-5f, -18f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(4f, 0f, -1f),
                        Size = new Vector3(2f, 18f, 2f),
                        UV = new Vector2(48f, 0f),
                    });
                })
                .AddElement("tentacle2", element => {
                    element.Translate = new Vector3(-3.5f, -18f, 3.5f);

                    element.Submodels.Add(new EntityElement {
                        Name = "tentacle2_rotation",
                        Translate = new Vector3(3.5f, 9f, -3.5f),
                        RotationAngleY = 135f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -9f, -1f),
                                Size = new Vector3(2f, 18f, 2f),
                                UV = new Vector2(48f, 0f),
                            },
                        },
                    });
                })
                .AddElement("tentacle3", element => {
                    element.Translate = new Vector3(0f, -18f, 5f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 0f, -6f),
                        Size = new Vector3(2f, 18f, 2f),
                        UV = new Vector2(48f, 0f),
                    });
                })
                .AddElement("tentacle4", element => {
                    element.Translate = new Vector3(3.5f, -18f, 3.5f);

                    element.Submodels.Add(new EntityElement {
                        Name = "tentacle4_rotation",
                        Translate = new Vector3(-3.5f, 9f, -3.5f),
                        RotationAngleY = -135f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -9f, -1f),
                                Size = new Vector3(2f, 18f, 2f),
                                UV = new Vector2(48f, 0f),
                            },
                        },
                    });
                })
                .AddElement("tentacle5", element => {
                    element.Translate = new Vector3(-10f, -18f, 5f);
                    element.RotationAngleY = -90;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 0f, -11f),
                        Size = new Vector3(2f, 18f, 2f),
                        UV = new Vector2(48f, 0f),
                    });
                })
                .AddElement("tentacle6", element => {
                    element.Translate = new Vector3(3.5f, -18f, -3.5f);

                    element.Submodels.Add(new EntityElement {
                        Name = "tentacle6_rotation",
                        Translate = new Vector3(-3.5f, 9f, 3.5f),
                        RotationAngleY = -45f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -9f, -1f),
                                Size = new Vector3(2f, 18f, 2f),
                                UV = new Vector2(48f, 0f),
                            },
                        },
                    });
                })
                .AddElement("tentacle7", element => {
                    element.Translate = new Vector3(0f, -18f, -1.65f);
                    element.RotationAngleY = -180f;

                    element.Submodels.Add(new EntityElement {
                        Name = "tentacle7_rotation",
                        Translate = new Vector3(0f, 9f, -1.7f),
                        RotationAngleY = -180f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -9f, -1f),
                                Size = new Vector3(2f, 18f, 2f),
                                UV = new Vector2(48f, 0f),
                            },
                        },
                    });
                })
                .AddElement("tentacle8", element => {
                    element.Translate = new Vector3(-3.5f, -18f, -3.5f);

                    element.Submodels.Add(new EntityElement {
                        Name = "tentacle8_rotation",
                        Translate = new Vector3(3.5f, 9f, 3.5f),
                        RotationAngleY = 45f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -9f, -1f),
                                Size = new Vector3(2f, 18f, 2f),
                                UV = new Vector2(48f, 0f),
                            },
                        },
                    });
                });
        }
    }
}
