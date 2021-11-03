using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Zoglin : JavaEntityModel
    {
        public Zoglin() : base("Zoglin")
        {
            AddVersion("zoglin", "1.0.0")
                .WithTextureSize(128, 64)
                .AddElement("head", element => {
                    element.Translate = new Vector3(0f, -21f, 8.5f);

                    element.Submodels.Add(new EntityElement {
                        Name = "head_rotation",
                        Translate = new Vector3(0f, 21f, -8.5f),
                        RotationAngleX = -50,

                        Cubes = {
                            new EntityElementCube {
                                Position = new Vector3(-7f, -3f, -19f),
                                Size = new Vector3(14f, 6f, 19f),
                                UV = new Vector2(61f, 1f),
                            },
                            new EntityElementCube {
                                Position = new Vector3(-8f, -2f, -13f),
                                Size = new Vector3(2f, 11f, 2f),
                                UV = new Vector2(1f, 13f),
                            },
                            new EntityElementCube {
                                Position = new Vector3(6f, -2f, -13f),
                                Size = new Vector3(2f, 11f, 2f),
                                UV = new Vector2(10f, 13f),
                            },
                        },
                    });
                })
                .AddElement("left_ear", element => {
                    element.Translate = new Vector3(6f, -23f, 11.5f);

                    element.Submodels.Add(new EntityElement {
                        Name = "left_ear_rotation",
                        Translate = new Vector3(0.5f, 21.25f, -8.5f),
                        RotationAngleX = -50,

                        Submodels = {
                            new EntityElement {
                                Name = "left_ear_rotation2",
                                Translate = new Vector3(-6.5f, 1.75f, -3f),
                                RotationAngleZ = 45f,

                                Cubes = {
                                    new EntityElementCube {
                                        Position = new Vector3(-6f, 0f, -2f),
                                        Size = new Vector3(6f, 1f, 4f),
                                        UV = new Vector2(1f, 6f),
                                    },
                                },
                            },
                        },
                    });
                })
                .AddElement("right_ear", element => {
                    element.Translate = new Vector3(-6f, -23f, 11.5f);

                    element.Submodels.Add(new EntityElement {
                        Name = "right_ear_rotation",
                        Translate = new Vector3(-0.5f, 21.25f, -8.5f),
                        RotationAngleX = -50,

                        Submodels = {
                            new EntityElement {
                                Name = "right_ear_rotation2",
                                Translate = new Vector3(6.5f, 1.75f, -3f),
                                RotationAngleZ = -45f,

                                Cubes = {
                                    new EntityElementCube {
                                        Position = new Vector3(0f, 0f, -2f),
                                        Size = new Vector3(6f, 1f, 4f),
                                        UV = new Vector2(1f, 1f),
                                    },
                                },
                            },
                        },
                    });
                })
                .AddElement("body", element => {
                    element.Translate = new Vector3(0f, -17f, -4.5f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, 10f, -8.5f),
                        Size = new Vector3(16f, 14f, 26f),
                        UV = new Vector2(1f, 1f),
                    });
                })
                .AddElement("mane", element => {
                    element.Translate = new Vector3(0f, -31f, 2.5f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 21f, -11.5f),
                        Size = new Vector3(0f, 10f, 19f),
                        UV = new Vector2(90f, 33f),
                    });
                })
                .AddElement("front_left_leg", element => {
                    element.Translate = new Vector3(4f, -14f, 4.75f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-7f, 0f, -7.5f),
                        Size = new Vector3(6f, 14f, 6f),
                        UV = new Vector2(41f, 42f),
                    });
                })
                .AddElement("front_right_leg", element => {
                    element.Translate = new Vector3(-4f, -14f, 4.5f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(1f, 0f, -7.5f),
                        Size = new Vector3(6f, 14f, 6f),
                        UV = new Vector2(66f, 42f),
                    });
                })
                .AddElement("back_left_leg", element => {
                    element.Translate = new Vector3(4.5f, -11f, -14f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-7f, 0f, 11.5f),
                        Size = new Vector3(5f, 11f, 5f),
                        UV = new Vector2(0f, 45f),
                    });
                })
                .AddElement("back_right_leg", element => {
                    element.Translate = new Vector3(-4.5f, -11f, -14f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(2f, 0f, 11.5f),
                        Size = new Vector3(5f, 11f, 5f),
                        UV = new Vector2(21f, 45f),
                    });
                });
        }
    }
}
