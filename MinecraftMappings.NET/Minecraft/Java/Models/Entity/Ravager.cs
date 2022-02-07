using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Ravager : JavaEntityModel
    {
        public Ravager() : base("Ravager")
        {
            AddVersion("ravager", "1.0.0")
                .WithTextureSize(128, 128)
                .AddElement("head", element => {
                    element.Translate = new Vector3(0f, -14f, 10f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement("horns") {
                        Translate = new Vector3(5f, 27f, -19f),
                        RotationAngleX = -60,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Submodels = {
                            new EntityElement("left_horn") {
                                Translate = new Vector3(-5f, -27f, 19f),
                                InvertAxisX = true,
                                InvertAxisY = true,
                                MirrorTexU = true,

                                Cubes = {
                                    new EntityElementCube {
                                        Position = new Vector3(-10f, 27f, -20f),
                                        Size = new Vector3(2f, 14f, 4f),
                                        UV = new Vector2(74f, 55f),
                                    },
                                },
                            },
                        },

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(3f, 0f, -1f),
                                Size = new Vector3(2f, 14f, 4f),
                                UV = new Vector2(74f, 55f),
                            },
                        },
                    });

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, 14f, -24f),
                        Size = new Vector3(16f, 20f, 16f),
                    });
                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, 12f, -28f),
                        Size = new Vector3(4f, 8f, 4f),
                    });
                })
                .AddElement("jaw", element => {
                    element.Translate = new Vector3(0f, -16f, 8f);
                    element.RotationAngleX = -7f;
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, 13f, -22f),
                        Size = new Vector3(16f, 3f, 16f),
                        UV = new Vector2(0f, 36f),
                    });
                })
                .AddElement("body", element => {
                    element.Translate = new Vector3(0f, -23f, -3.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement("rotation") {
                        Translate = new Vector3(0f, 23f, 3.5f),
                        RotationAngleX = -90f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-7f, -6f, -7f),
                                Size = new Vector3(14f, 16f, 20f),
                                UV = new Vector2(0f, 55f),
                            },
                            new EntityElementCube {
                                Position = new Vector3(-6f, -19f, -7f),
                                Size = new Vector3(12f, 13f, 18f),
                                UV = new Vector2(0f, 91f),
                            },
                        },
                    });
                })
                .AddElement("leg1", element => {
                    element.Translate = new Vector3(-8f, -37f, -21f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(4f, 0f, 17f),
                        Size = new Vector3(8f, 37f, 8f),
                        UV = new Vector2(96f, 0f),
                    });
                })
                .AddElement("leg2", element => {
                    element.Translate = new Vector3(8f, -37f, -21f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-12f, 0f, 17f),
                        Size = new Vector3(8f, 37f, 8f),
                        UV = new Vector2(96f, 0f),
                    });
                })
                .AddElement("leg3", element => {
                    element.Translate = new Vector3(-8f, -37f, 3.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(4f, 0f, -7.5f),
                        Size = new Vector3(8f, 37f, 8f),
                        UV = new Vector2(64f, 0f),
                    });
                })
                .AddElement("leg4", element => {
                    element.Translate = new Vector3(8f, -37f, 3.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-12f, 0f, -7.5f),
                        Size = new Vector3(8f, 37f, 8f),
                        UV = new Vector2(64f, 0f),
                    });
                })
                .AddElement("neck", element => {
                    element.Translate = new Vector3(0f, -30f, -8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 21f, -10f),
                        Size = new Vector3(10f, 10f, 18f),
                        UV = new Vector2(68f, 73f),
                    });
                });
        }
    }
}
