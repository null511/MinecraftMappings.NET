using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Bed : JavaEntityModel
    {
        public Bed() : base("Bed")
        {
            AddVersion("bed", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("foot", element => {
                    element.Part = "foot";
                    element.Translate = new Vector3(-8f, -9f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "foot_rotation",
                        Translate = new Vector3(0f, 9f, 0f),
                        InvertAxisX = true,
                        InvertAxisY = true,
                        RotationAngleX = 90,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-8f, -16f, 0f),
                                Size = new Vector3(16f, 16f, 6f),
                                UV = new Vector2(0f, 22f),
                            },
                        },

                        Submodels = {
                            new EntityElement {
                                Id = "foot_left_leg",
                                Translate = new Vector3(0f, -16f, 0f),
                                InvertAxisX = true,
                                InvertAxisY = true,
                                RotationAngleX = -90,
                                RotationAngleZ = -90,

                                Boxes = {
                                    new EntityElementCube {
                                        Position = new Vector3(-3f, -9f, -8f),
                                        Size = new Vector3(3f, 3f, 3f),
                                        UV = new Vector2(50f, 12f),
                                    },
                                },
                            },
                            new EntityElement {
                                Id = "foot_right_leg",
                                Translate = new Vector3(0f, -16f, 0f),
                                InvertAxisX = true,
                                InvertAxisY = true,
                                RotationAngleX = -90,

                                Boxes = {
                                    new EntityElementCube {
                                        Position = new Vector3(5f, -9f, 0f),
                                        Size = new Vector3(3f, 3f, 3f),
                                        UV = new Vector2(50f, 0f),
                                    },
                                },
                            },
                        }
                    });
                })
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(-8f, -25f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "head_rotation",
                        Translate = new Vector3(0f, 9f, 0f),
                        InvertAxisX = true,
                        InvertAxisY = true,
                        RotationAngleX = 90,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-8f, 0f, 0f),
                                Size = new Vector3(16f, 16f, 6f),
                                UV = Vector2.Zero,
                            },
                        },

                        Submodels = {
                            new EntityElement {
                                Id = "head_left_leg",
                                Translate = new Vector3(0f, -16f, 0f),
                                InvertAxisX = true,
                                InvertAxisY = true,
                                RotationAngleX = -90,
                                RotationAngleZ = -180,

                                Boxes = {
                                    new EntityElementCube {
                                        Position = new Vector3(5f, -9f, -32f),
                                        Size = new Vector3(3f, 3f, 3f),
                                        UV = new Vector2(50f, 18f),
                                    },
                                }
                            },
                            new EntityElement {
                                Id = "head_right_leg",
                                Translate = new Vector3(0f, -16f, 0f),
                                InvertAxisX = true,
                                InvertAxisY = true,
                                RotationAngleX = -90,
                                RotationAngleZ = 90,

                                Boxes = {
                                    new EntityElementCube {
                                        Position = new Vector3(29f, -9f, -8f),
                                        Size = new Vector3(3f, 3f, 3f),
                                        UV = new Vector2(50f, 6f),
                                    },
                                }
                            },
                        }
                    });
                });
        }
    }
}
