using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Strider : JavaEntityModel
    {
        public Strider() : base("Strider")
        {
            AddVersion("strider", "1.16")
                .WithTextureSize(64, 128)
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -23f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, 15f, -8f),
                        Size = new Vector3(16f, 14f, 16f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("left_leg", element => {
                    element.Part = "left_leg";
                    element.Translate = new Vector3(-4f, -17f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(2f, 0f, -2f),
                        Size = new Vector3(4f, 17f, 4f),
                        UV = new Vector2(0f, 55f),
                    });
                })
                .AddElement("right_leg", element => {
                    element.Part = "right_leg";
                    element.Translate = new Vector3(4f, -17f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 0f, -2f),
                        Size = new Vector3(4f, 17f, 4f),
                        UV = new Vector2(0f, 32f),
                    });
                })
                .AddElement("hair_left_top", element => {
                    element.Part = "hair_left_top";
                    element.Translate = new Vector3(8f, -29f, 8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "hair_left_top_rotation",
                        Translate = new Vector3(-8f, 29f, 0f),
                        RotationAngleZ = 60f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-12f, 0f, -8f),
                                Size = new Vector3(12f, 0f, 16f),
                                UV = new Vector2(4f, 33f),
                            },
                        },
                    });
                })
                .AddElement("hair_left_middle", element => {
                    element.Part = "hair_left_middle";
                    element.Translate = new Vector3(8f, -25f, 8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "hair_left_middle_rotation",
                        Translate = new Vector3(-8f, 25f, 0f),
                        RotationAngleZ = 60f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-12f, 0f, -8f),
                                Size = new Vector3(12f, 0f, 16f),
                                UV = new Vector2(4f, 49f),
                            },
                        },
                    });
                })
                .AddElement("hair_left_bottom", element => {
                    element.Part = "hair_left_bottom";
                    element.Translate = new Vector3(8f, -20f, 8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "hair_left_bottom_rotation",
                        Translate = new Vector3(-8f, 20f, 0f),
                        RotationAngleZ = 60f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-12f, 0f, -8f),
                                Size = new Vector3(12f, 0f, 16f),
                                UV = new Vector2(4f, 65f),
                            },
                        },
                    });
                })
                .AddElement("hair_right_top", element => {
                    element.Part = "hair_right_top";
                    element.Translate = new Vector3(-8f, -28f, 8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "hair_left_top_rotation",
                        Translate = new Vector3(-8f, 29f, 0f),
                        RotationAngleZ = -60f,
                        InvertAxisX = true,
                        InvertAxisY = true,
                        MirrorTexU = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(0f, 0f, -8f),
                                Size = new Vector3(12f, 0f, 16f),
                                UV = new Vector2(4f, 33f),
                            },
                        },
                    });
                })
                .AddElement("hair_right_middle", element => {
                    element.Part = "hair_right_middle";
                    element.Translate = new Vector3(-8f, -24f, 8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "hair_right_middle_rotation",
                        Translate = new Vector3(8f, 24f, 0f),
                        RotationAngleZ = -60f,
                        InvertAxisX = true,
                        InvertAxisY = true,
                        MirrorTexU = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(0f, 0f, -8f),
                                Size = new Vector3(12f, 0f, 16f),
                                UV = new Vector2(4f, 49f),
                            },
                        },
                    });
                })
                .AddElement("hair_right_bottom", element => {
                    element.Part = "hair_right_bottom";
                    element.Translate = new Vector3(-8f, -19f, 8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "hair_right_bottom_rotation",
                        Translate = new Vector3(8f, 19f, 0f),
                        RotationAngleZ = -60f,
                        InvertAxisX = true,
                        InvertAxisY = true,
                        MirrorTexU = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(0f, 0f, -8f),
                                Size = new Vector3(12f, 0f, 16f),
                                UV = new Vector2(4f, 65f),
                            },
                        },
                    });
                });
        }
    }
}
