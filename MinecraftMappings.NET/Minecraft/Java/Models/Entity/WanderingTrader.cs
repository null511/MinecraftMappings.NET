using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class WanderingTrader : JavaEntityModel
    {
        public WanderingTrader() : base("Wandering Trader")
        {
            AddVersion("wandering_trader", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 24f, -4f),
                        Size = new Vector3(8f, 10f, 8f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("headwear", element => {
                    element.Part = "headwear";
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 24f, -4f),
                        Size = new Vector3(8f, 10f, 8f),
                        UV = new Vector2(32f, 0f),
                        SizeAdd = 0.5f,
                    });
                })
                .AddElement("headwear2", element => {
                    element.Part = "headwear2";
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "rotation",
                        Translate = new Vector3(0f, 24f, 0f),
                        RotationAngleX = 90,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-8f, -8f, -6f),
                                Size = new Vector3(16f, 16f, 1f),
                                UV = new Vector2(30f, 47f),
                            },
                        },
                    });
                })
                .AddElement("nose", element => {
                    element.Part = "nose";
                    element.Translate = new Vector3(0f, -26f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 23f, -6f),
                        Size = new Vector3(2f, 4f, 2f),
                        UV = new Vector2(24f, 0f),
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 12f, -3f),
                        Size = new Vector3(8f, 12f, 6f),
                        UV = new Vector2(16f, 20f),
                    });
                })
                .AddElement("bodywear", element => {
                    element.Part = "bodywear";
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 6f, -3f),
                        Size = new Vector3(8f, 18f, 6f),
                        UV = new Vector2(0f, 38f),
                        SizeAdd = 0.25f,
                    });
                })
                .AddElement("arms", element => {
                    element.Part = "arms";
                    element.Translate = new Vector3(0f, -20.5f, -0.3f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "arms_rotation",
                        Translate = new Vector3(0f, 22.5f, 0.35f),
                        RotationAngleX = 43f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(4f, -8f, -2.05f),
                                Size = new Vector3(4f, 8f, 4f),
                                UV = new Vector2(44f, 22f),
                            },
                            new EntityElementCube {
                                Position = new Vector3(-4f, -8f, -2.05f),
                                Size = new Vector3(8f, 4f, 4f),
                                UV = new Vector2(40f, 38f),
                            },
                        },

                        Submodels = {
                            new EntityElement {
                                Id = "arms_flipped",
                                Translate = new Vector3(0f, -24f, 0f),
                                InvertAxisX = true,
                                InvertAxisY = true,
                                MirrorTexU = true,

                                Boxes = {
                                    new EntityElementCube {
                                        Position = new Vector3(-8f, 16f, -2.05f),
                                        Size = new Vector3(4f, 8f, 4f),
                                        UV = new Vector2(44f, 22f),
                                    },
                                },
                            },
                        }
                    });
                })
                .AddElement("right_leg", element => {
                    element.Part = "right_leg";
                    element.Translate = new Vector3(-2f, -12f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 0f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 22f),
                    });
                })
                .AddElement("left_leg", element => {
                    element.Part = "left_leg";
                    element.Translate = new Vector3(2f, -12f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 0f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 22f),
                    });
                });
        }
    }
}
