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
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -25f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 17f, -6f),
                        Size = new Vector3(12f, 16f, 12f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("tentacle1", element => {
                    element.Part = "tentacle1";
                    element.Translate = new Vector3(-5f, -18f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(4f, 0f, -1f),
                        Size = new Vector3(2f, 18f, 2f),
                        UV = new Vector2(48f, 0f),
                    });
                })
                .AddElement("tentacle2", element => {
                    element.Part = "tentacle2";
                    element.Translate = new Vector3(-3.5f, -18f, 3.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "tentacle2_rotation",
                        Translate = new Vector3(3.5f, 9f, -3.5f),
                        RotationAngleY = 135f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -9f, -1f),
                                Size = new Vector3(2f, 18f, 2f),
                                UV = new Vector2(48f, 0f),
                            },
                        },
                    });
                })
                .AddElement("tentacle3", element => {
                    element.Part = "tentacle3";
                    element.Translate = new Vector3(0f, -18f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 0f, -6f),
                        Size = new Vector3(2f, 18f, 2f),
                        UV = new Vector2(48f, 0f),
                    });
                })
                .AddElement("tentacle4", element => {
                    element.Part = "tentacle4";
                    element.Translate = new Vector3(3.5f, -18f, 3.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "tentacle4_rotation",
                        Translate = new Vector3(-3.5f, 9f, -3.5f),
                        RotationAngleY = -135f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -9f, -1f),
                                Size = new Vector3(2f, 18f, 2f),
                                UV = new Vector2(48f, 0f),
                            },
                        },
                    });
                })
                .AddElement("tentacle5", element => {
                    element.Part = "tentacle5";
                    element.Translate = new Vector3(-10f, -18f, 5f);
                    element.RotationAngleY = -90;
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 0f, -11f),
                        Size = new Vector3(2f, 18f, 2f),
                        UV = new Vector2(48f, 0f),
                    });
                })
                .AddElement("tentacle6", element => {
                    element.Part = "tentacle6";
                    element.Translate = new Vector3(3.5f, -18f, -3.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "tentacle6_rotation",
                        Translate = new Vector3(-3.5f, 9f, 3.5f),
                        RotationAngleY = -45f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -9f, -1f),
                                Size = new Vector3(2f, 18f, 2f),
                                UV = new Vector2(48f, 0f),
                            },
                        },
                    });
                })
                .AddElement("tentacle7", element => {
                    element.Part = "tentacle7";
                    element.Translate = new Vector3(0f, -18f, -1.65f);
                    element.RotationAngleY = -180f;
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "tentacle7_rotation",
                        Translate = new Vector3(0f, 9f, -1.7f),
                        RotationAngleY = -180f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -9f, -1f),
                                Size = new Vector3(2f, 18f, 2f),
                                UV = new Vector2(48f, 0f),
                            },
                        },
                    });
                })
                .AddElement("tentacle8", element => {
                    element.Part = "tentacle8";
                    element.Translate = new Vector3(-3.5f, -18f, -3.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "tentacle8_rotation",
                        Translate = new Vector3(3.5f, 9f, 3.5f),
                        RotationAngleY = 45f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
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
