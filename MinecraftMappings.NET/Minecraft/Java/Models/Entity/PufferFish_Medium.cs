using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class PufferFish_Medium : JavaEntityModel
    {
        public PufferFish_Medium() : base("PufferFish, Medium")
        {
            AddVersion("puffer_fish_medium", "1.0.0")
                .WithTextureSize(32, 32)
                .AddElement("body", element => {
                    element.Part = "body";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2.5f, 1f, -2.5f),
                        Size = new Vector3(5f, 5f, 5f),
                        UV = new Vector2(12f, 22f),
                    });

                    element.Submodels.Add(new EntityElement {
                        Id = "top_front_spikes",
                        Translate = new Vector3(0f, 6f, -2.5f),
                        RotationAngleX = -45,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-2.5f, 0f, 0f),
                                Size = new Vector3(5f, 1f, 1f),
                                UV = new Vector2(15f, 16f),
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "left_front_spikes",
                        Translate = new Vector3(-2.5f, 3.5f, -2.5f),
                        RotationAngleY = -45,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -2.5f, 0f),
                                Size = new Vector3(1f, 5f, 1f),
                                UV = new Vector2(0f, 16f),
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "right_front_spikes",
                        Translate = new Vector3(2.5f, 3.5f, -2.5f),
                        RotationAngleY = 45,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(0f, -2.5f, 0f),
                                Size = new Vector3(1f, 5f, 1f),
                                UV = new Vector2(8f, 16f),
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "bottom_front_spikes",
                        Translate = new Vector3(0f, 1f, -2.5f),
                        RotationAngleX = 45,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-2.5f, -1f, 0f),
                                Size = new Vector3(5f, 1f, 1f),
                                UV = new Vector2(17f, 21f),
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "top_back_spikes",
                        Translate = new Vector3(0f, 6f, 2.5f),
                        RotationAngleX = 45,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-2.5f, 0f, -1f),
                                Size = new Vector3(5f, 1f, 1f),
                                UV = new Vector2(10f, 16f),
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "left_back_spikes",
                        Translate = new Vector3(2.5f, 3.5f, 2.5f),
                        RotationAngleY = -45,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(0f, -2.5f, 0f),
                                Size = new Vector3(1f, 5f, 1f),
                                UV = new Vector2(8f, 16f),
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "right_back_spikes",
                        Translate = new Vector3(-2.5f, 3.5f, 2.5f),
                        RotationAngleY = 45,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-1f, -2.5f, 0f),
                                Size = new Vector3(1f, 5f, 1f),
                                UV = new Vector2(4f, 16f),
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "bottom_back_spikes",
                        Translate = new Vector3(-1f, 1f, 2.5f),
                        RotationAngleX = -45,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-0.5f, -1f, 0f),
                                Size = new Vector3(1f, 1f, 1f),
                                UV = new Vector2(8f, 22f),
                            },
                        },
                    });
                })
                .AddElement("fin_right", element => {
                    element.Part = "fin_right";
                    element.Translate = new Vector3(-2.5f, -6f, 1.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(2.5f, 6f, -1.49f),
                        Size = new Vector3(2f, 0f, 2f),
                        UV = new Vector2(24f, 0f),
                    });
                })
                .AddElement("fin_left", element => {
                    element.Part = "fin_left";
                    element.Translate = new Vector3(2.5f, -6f, 1.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4.5f, 6f, -1.5f),
                        Size = new Vector3(2f, 0f, 2f),
                        UV = new Vector2(24f, 3f),
                    });
                })
                .AddElement("spikes_front_top", element => {
                    element.Part = "spikes_front_top";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("spikes_back_top", element => {
                    element.Part = "spikes_back_top";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("spikes_front_right", element => {
                    element.Part = "spikes_front_right";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("spikes_back_right", element => {
                    element.Part = "spikes_back_right";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("spikes_front_left", element => {
                    element.Part = "spikes_front_left";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("spikes_back_left", element => {
                    element.Part = "spikes_back_left";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("spikes_front_bottom", element => {
                    element.Part = "spikes_front_bottom";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("spikes_back_bottom", element => {
                    element.Part = "spikes_back_bottom";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                });
        }
    }
}
