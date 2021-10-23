using MinecraftMappings.Internal.Models.Entity;
using SharpDX;
using System.Collections.Generic;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Witch : JavaEntityModel
    {
        public Witch() : base("Witch")
        {
            AddVersion("witch", "1.4.2");

            AddVersion("witch", "1.14")
                .WithTextureSize(64, 128)
                .AddElement("head", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 24f, -4f),
                        Size = new Vector3(8f, 10f, 8f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("headwear", element => {
                    element.Translate = new Vector3(-5f, -34.05f, 5f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 32.05f, -5f),
                        Size = new Vector3(10f, 2f, 10f),
                        UV = new Vector2(0f, 64f),
                    });

                    element.Submodels = new List<EntityElement> {
                        new EntityElement {
                            Name = "hat2",
                            Translate = new Vector3(3.25f, 38.05f, -3f),
                            RotationAngleX = 3f,
                            RotationAngleZ = 1.5f,

                            Cubes = {
                                new EntityElementCube {
                                    Position = new Vector3(-7f, -4f, 0f),
                                    Size = new Vector3(7f, 4f, 7f),
                                    UV = new Vector2(0f, 76f),
                                },
                            },

                            Submodels = new List<EntityElement> {
                                new EntityElement {
                                    Name = "hat3",
                                    Translate = new Vector3(-1.75f, 4f, 2f),
                                    RotationAngleX = 6f,
                                    RotationAngleZ = 3f,

                                    Cubes = {
                                        new EntityElementCube {
                                            Position = new Vector3(-4f, -4f, 0f),
                                            Size = new Vector3(4f, 4f, 4f),
                                            UV = new Vector2(0f, 87f),
                                        },
                                    },

                                    Submodels = new List<EntityElement> {
                                        new EntityElement {
                                            Name = "hat4",
                                            Translate = new Vector3(-1.75f, 2f, 2f),
                                            RotationAngleX = 12f,
                                            RotationAngleZ = 6f,

                                            Cubes = {
                                                new EntityElementCube {
                                                    Position = new Vector3(-1f, -2f, 0f),
                                                    Size = new Vector3(1f, 2f, 1f),
                                                    UV = new Vector2(0f, 95f),
                                                    Inflate = 0.25f,
                                                },
                                            },
                                        },
                                    }
                                },
                            }
                        },
                    };
                })
                .AddElement("nose", element => {
                    element.Translate = new Vector3(0f, -26f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 23f, -6f),
                        Size = new Vector3(2f, 4f, 2f),
                        UV = new Vector2(24f, 0f),
                    });
                })
                .AddElement("mole", element => {
                    element.Translate = new Vector3(0f, -28f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 24f, -6.75f),
                        Size = new Vector3(1f, 1f, 1f),
                        UV = Vector2.Zero,
                        Inflate = -0.25f,
                    });
                })
                .AddElement("body", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 12f, -3f),
                        Size = new Vector3(8f, 12f, 6f),
                        UV = new Vector2(16f, 20f),
                    });
                })
                .AddElement("bodywear", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 6f, -3f),
                        Size = new Vector3(8f, 18f, 6f),
                        UV = new Vector2(0f, 38f),
                        Inflate = 0.5f,
                    });
                })
                .AddElement("arms", element => {
                    element.Translate = new Vector3(0f, -20.5f, -0.3f);

                    element.Submodels.Add(new EntityElement {
                        Name = "arms_rotation",
                        Translate = new Vector3(0f, 22.5f, 0.35f),
                        RotationAngleX = 43f,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(4f, -8f, -2f),
                                Size = new Vector3(4f, 8f, 4f),
                                UV = new Vector2(44f, 22f),
                            },
                            new EntityElementCube {
                                Position = new Vector3(-4f, -8f, -2f),
                                Size = new Vector3(8f, 4f, 4f),
                                UV = new Vector2(40f, 38f),
                            },
                        },

                        Submodels = {
                            new EntityElement {
                                Name = "arms_flipped",
                                Translate = new Vector3(0f, -24f, 0f),
                                MirrorUVX = true,

                                Cubes = {
                                    new EntityElementCube {
                                        Position = new Vector3(-8f, 16f, -2f),
                                        Size = new Vector3(4f, 8f, 4f),
                                        UV = new Vector2(44f, 22f),
                                    },
                                },
                            },
                        }
                    });
                })
                .AddElement("left_leg", element => {
                    element.Translate = new Vector3(2f, -12f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 0f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 22f),
                    });
                })
                .AddElement("right_leg", element => {
                    element.Translate = new Vector3(-2f, -12f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 0f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 22f),
                    });
                });
        }
    }
}
