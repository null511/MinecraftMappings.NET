using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class PufferFish_Big : JavaEntityModel
    {
        public PufferFish_Big() : base("PufferFish, Big")
        {
            AddVersion("puffer_fish_big", "1.0.0")
                .WithTextureSize(32, 32)
                .AddElement("body", element => {
                    element.Part = "body";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 0f, -4f),
                        Size = new Vector3(8f, 8f, 8f),
                        UV = Vector2.Zero,
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 8f, 0f),
                        Size = new Vector3(8f, 1f, 1f),
                        UV = new Vector2(14f, 16f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, -1f, 0f),
                        Size = new Vector3(8f, 1f, 0f),
                        UV = new Vector2(15f, 20f),
                    });

                    element.Submodels.Add(new EntityElement {
                        Id = "top_front_spikes",
                        Translate = new Vector3(0f, 8f, -4f),
                        RotationAngleX = -45,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-4f, 0f, 0f),
                                Size = new Vector3(8f, 1f, 0f),
                                UV = new Vector2(15f, 17f),
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "left_front_spikes",
                        Translate = new Vector3(-4f, 4f, -4f),
                        RotationAngleY = -45,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -4f, 0f),
                                Size = new Vector3(1f, 8f, 0f),
                                UV = new Vector2(1f, 17f),
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "right_front_spikes",
                        Translate = new Vector3(4f, 4f, -4f),
                        RotationAngleY = 45,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(0f, -4f, 0f),
                                Size = new Vector3(1f, 8f, 0f),
                                UV = new Vector2(5f, 17f),
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "bottom_front_spikes",
                        Translate = new Vector3(0f, 0f, -4f),
                        RotationAngleX = 45,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-4f, -1f, 0f),
                                Size = new Vector3(8f, 1f, 0f),
                                UV = new Vector2(15f, 20f),
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "top_back_spikes",
                        Translate = new Vector3(0f, 8f, 4f),
                        RotationAngleX = 45,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-4f, 0f, 0f),
                                Size = new Vector3(8f, 1f, 0f),
                                UV = new Vector2(23f, 18f),
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "left_back_spikes",
                        Translate = new Vector3(-4f, 4f, 4f),
                        RotationAngleY = 45,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -4f, 0f),
                                Size = new Vector3(1f, 8f, 0f),
                                UV = new Vector2(9f, 17f),
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "right_back_spikes",
                        Translate = new Vector3(4f, 4f, 4f),
                        RotationAngleY = -45,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(0f, -4f, 0f),
                                Size = new Vector3(1f, 8f, 0f),
                                UV = new Vector2(9f, 17f),
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "bottom_back_spikes",
                        Translate = new Vector3(0f, 0f, 4f),
                        RotationAngleX = -45,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-4f, -1f, 0f),
                                Size = new Vector3(8f, 1f, 0f),
                                UV = new Vector2(15f, 20f),
                            },
                        },
                    });
                })
                .AddElement("fin_left", element => {
                    element.Part = "fin_left";
                    element.Translate = new Vector3(4f, -7f, 2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 6f, -2.99f),
                        Size = new Vector3(2f, 1f, 2f),
                        UV = new Vector2(24f, 3f),
                    });
                })
                .AddElement("fin_right", element => {
                    element.Part = "fin_right";
                    element.Translate = new Vector3(-4f, -7f, 2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(4f, 6f, -2.99f),
                        Size = new Vector3(2f, 1f, 2f),
                        UV = new Vector2(24f, 0f),
                    });
                })
                .AddElement("spikes_front_top", element => {
                    element.Part = "spikes_front_top";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("spikes_middle_top", element => {
                    element.Part = "spikes_middle_top";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("spikes_back_top", element => {
                    element.Part = "spikes_back_top";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("spikes_front_left", element => {
                    element.Part = "spikes_front_left";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("spikes_front_right", element => {
                    element.Part = "spikes_front_right";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("spikes_front_bottom", element => {
                    element.Part = "spikes_front_bottom";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("spikes_middle_bottom", element => {
                    element.Part = "spikes_middle_bottom";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("spikes_back_bottom", element => {
                    element.Part = "spikes_back_bottom";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("spikes_back_left", element => {
                    element.Part = "spikes_back_left";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("spikes_back_right", element => {
                    element.Part = "spikes_back_right";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                });
        }
    }
}
