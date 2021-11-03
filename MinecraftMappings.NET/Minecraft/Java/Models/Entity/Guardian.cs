using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Guardian : JavaEntityModel
    {
        public Guardian() : base("Guardian")
        {
            AddVersion("guardian", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("body", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 2f, -8f),
                        Size = new Vector3(12f, 12f, 16f),
                        UV = Vector2.Zero,
                    });
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 14f, -6f),
                        Size = new Vector3(12f, 2f, 12f),
                        UV = new Vector2(16f, 40f),
                    });
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 0f, -6f),
                        Size = new Vector3(12f, 2f, 12f),
                        UV = new Vector2(16f, 40f),
                    });
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(6f, 2f, -6f),
                        Size = new Vector3(2f, 12f, 12f),
                        UV = new Vector2(0f, 28f),
                    });

                    element.Submodels.Add(new EntityElement {
                        Name = "body_flipped",
                        MirrorTexU = true,

                        Submodels = {
                            new EntityElement {
                                Name = "body_sub_1",
                                MirrorTexU = true,

                                Cubes = {
                                    new EntityElementCube {
                                        Position = new Vector3(-8f, 2f, -6f),
                                        Size = new Vector3(2f, 12f, 12f),
                                        UV = new Vector2(0f, 28f),
                                    },
                                },
                            },
                        }
                    });
                })
                .AddElement("eye", element => {
                    element.Translate = new Vector3(0f, -23.5f, 8.25f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 6.5f, -8.25f),
                        Size = new Vector3(2f, 2f, 1f),
                        UV = new Vector2(8f, 0f),
                    });
                })
                .AddElement("tail1", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, 6f, 7f),
                        Size = new Vector3(4f, 4f, 8f),
                        UV = new Vector2(40f, 0f),
                    });
                })
                .AddElement("tail2", element => {
                    element.Translate = new Vector3(-1.5f, -23.5f, -14f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-1.5f, 6.5f, 14f),
                        Size = new Vector3(3f, 3f, 7f),
                        UV = new Vector2(0f, 54f),
                    });
                })
                .AddElement("tail3", element => {
                    element.Translate = new Vector3(-1f, -23f, -20f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 7f, 20f),
                        Size = new Vector3(2f, 2f, 6f),
                        UV = new Vector2(41f, 32f),
                    });
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 3.5f, 23f),
                        Size = new Vector3(1f, 9f, 9f),
                        UV = new Vector2(25f, 19f),
                    });
                })
                .AddElement("spine1", element => {
                    element.Translate = new Vector3(0f, -12.5f, -7f);

                    element.Submodels.Add(new EntityElement {
                        Name = "spine1_rotation",
                        Translate = new Vector3(0f, 15f, 7f),
                        RotationAngleX = 45f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -7f, -1f),
                                Size = new Vector3(2f, 9f, 2f),
                                UV = Vector2.Zero,
                            },
                        },
                    });
                })
                .AddElement("spine2", element => {
                    element.Translate = new Vector3(0f, -12.5f, 7f);

                    element.Submodels.Add(new EntityElement {
                        Name = "spine2_rotation",
                        Translate = new Vector3(0f, 15f, -7f),
                        RotationAngleX = -45f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -7f, -1f),
                                Size = new Vector3(2f, 9f, 2f),
                                UV = Vector2.Zero,
                            },
                        },
                    });
                })
                .AddElement("spine3", element => {
                    element.Translate = new Vector3(7f, -12.5f, 0f);

                    element.Submodels.Add(new EntityElement {
                        Name = "spine3_rotation",
                        Translate = new Vector3(-7f, 15f, 0f),
                        RotationAngleZ = 45f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -7f, -1f),
                                Size = new Vector3(2f, 9f, 2f),
                                UV = Vector2.Zero,
                            },
                        },
                    });
                })
                .AddElement("spine4", element => {
                    element.Translate = new Vector3(-7f, -12.5f, 0f);

                    element.Submodels.Add(new EntityElement {
                        Name = "spine4_rotation",
                        Translate = new Vector3(7f, 15f, 0f),
                        RotationAngleZ = -45f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -7f, -1f),
                                Size = new Vector3(2f, 9f, 2f),
                                UV = Vector2.Zero,
                            },
                        },
                    });
                })
                .AddElement("spine5", element => {
                    element.Translate = new Vector3(-7f, -5.5f, 7f);

                    element.Submodels.Add(new EntityElement {
                        Name = "spine5_rotation",
                        Translate = new Vector3(7f, 8f, -7f),
                        RotationAngleX = -90f,
                        RotationAngleY = -45f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -7f, -1f),
                                Size = new Vector3(2f, 9f, 2f),
                                UV = Vector2.Zero,
                            },
                        },
                    });
                })
                .AddElement("spine6", element => {
                    element.Translate = new Vector3(7f, -5.5f, 7f);

                    element.Submodels.Add(new EntityElement {
                        Name = "spine6_rotation",
                        Translate = new Vector3(-7f, 8f, -7f),
                        RotationAngleX = -90f,
                        RotationAngleY = 45f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -7f, -1f),
                                Size = new Vector3(2f, 9f, 2f),
                                UV = Vector2.Zero,
                            },
                        },
                    });
                })
                .AddElement("spine7", element => {
                    element.Translate = new Vector3(7f, -5.5f, -7f);

                    element.Submodels.Add(new EntityElement {
                        Name = "spine7_rotation",
                        Translate = new Vector3(-7f, 8f, 7f),
                        RotationAngleX = 90f,
                        RotationAngleY = -45f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -7f, -1f),
                                Size = new Vector3(2f, 9f, 2f),
                                UV = Vector2.Zero,
                            },
                        },
                    });
                })
                .AddElement("spine8", element => {
                    element.Translate = new Vector3(-7f, -5.5f, -7f);

                    element.Submodels.Add(new EntityElement {
                        Name = "spine8_rotation",
                        Translate = new Vector3(7f, 8f, 7f),
                        RotationAngleX = 90f,
                        RotationAngleY = 45f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -7f, -1f),
                                Size = new Vector3(2f, 9f, 2f),
                                UV = Vector2.Zero,
                            },
                        },
                    });
                })
                .AddElement("spine9", element => {
                    element.Translate = new Vector3(0f, 1.5f, -7f);

                    element.Submodels.Add(new EntityElement {
                        Name = "spine9_rotation",
                        Translate = new Vector3(0f, 1f, 7f),
                        RotationAngleX = 135f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -7f, -1f),
                                Size = new Vector3(2f, 9f, 2f),
                                UV = Vector2.Zero,
                            },
                        },
                    });
                })
                .AddElement("spine10", element => {
                    element.Translate = new Vector3(0f, 1.5f, 7f);

                    element.Submodels.Add(new EntityElement {
                        Name = "spine10_rotation",
                        Translate = new Vector3(0f, 1f, -7f),
                        RotationAngleX = -135f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -7f, -1f),
                                Size = new Vector3(2f, 9f, 2f),
                                UV = Vector2.Zero,
                            },
                        },
                    });
                })
                .AddElement("spine11", element => {
                    element.Translate = new Vector3(7f, 1.5f, 0f);

                    element.Submodels.Add(new EntityElement {
                        Name = "spine11_rotation",
                        Translate = new Vector3(-7f, 1f, 0f),
                        RotationAngleZ = 135f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -7f, -1f),
                                Size = new Vector3(2f, 9f, 2f),
                                UV = Vector2.Zero,
                            },
                        },
                    });
                })
                .AddElement("spine12", element => {
                    element.Translate = new Vector3(-7f, 1.5f, 0f);

                    element.Submodels.Add(new EntityElement {
                        Name = "spine11_rotation",
                        Translate = new Vector3(7f, 1f, 0f),
                        RotationAngleZ = -135f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -7f, -1f),
                                Size = new Vector3(2f, 9f, 2f),
                                UV = Vector2.Zero,
                            },
                        },
                    });
                });
        }
    }
}
