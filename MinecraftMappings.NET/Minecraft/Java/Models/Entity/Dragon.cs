using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Dragon : JavaEntityModel
    {
        public Dragon() : base("Dragon")
        {
            AddVersion("dragon", "1.0.0")
                .WithTextureSize(256, 256)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -6f, 24f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 2f, -48f),
                        Size = new Vector3(12f, 5f, 16f),
                        UV = new Vector2(176f, 44f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, -2f, -34f),
                        Size = new Vector3(16f, 16f, 16f),
                        UV = new Vector2(112f, 30f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 14f, -28f),
                        Size = new Vector3(2f, 4f, 6f),
                        UV = Vector2.Zero,
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 7f, -46f),
                        Size = new Vector3(2f, 2f, 4f),
                        UV = new Vector2(112, 0f),
                    });

                    element.Submodels.Add(new EntityElement("mirrored") {
                        InvertAxisX = true,
                        InvertAxisY = true,
                        MirrorTexU = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(3f, 14f, -28f),
                                Size = new Vector3(2f, 4f, 6f),
                                UV = Vector2.Zero,
                            },
                            new EntityElementCube {
                                Position = new Vector3(3f, 7f, -46f),
                                Size = new Vector3(2f, 2f, 4f),
                                UV = new Vector2(112f, 0f),
                            },
                        },
                    });
                })
                .AddElement("spine", element => {
                    element.Part = "spine";
                    element.Translate = new Vector3(0f, -5f, 13f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 0f, -18f),
                        Size = new Vector3(10f, 10f, 10f),
                        UV = new Vector2(192f, 104f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 10f, -16f),
                        Size = new Vector3(2f, 4f, 6f),
                        UV = new Vector2(48f, 0f),
                    });
                })
                .AddElement("jaw", element => {
                    element.Part = "jaw";
                    element.Translate = new Vector3(0f, -2f, 32f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, -2f, -48f),
                        Size = new Vector3(12f, 4f, 16f),
                        UV = new Vector2(176f, 65f),
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -20f, -8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-12f, -4f, -8f),
                        Size = new Vector3(24f, 24f, 64f),
                        UV = Vector2.Zero,
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 20f, -2f),
                        Size = new Vector3(2f, 6f, 12f),
                        UV = new Vector2(220f, 53f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 20f, 18f),
                        Size = new Vector3(2f, 6f, 12f),
                        UV = new Vector2(220f, 53f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 20f, 38f),
                        Size = new Vector3(2f, 6f, 12f),
                        UV = new Vector2(220f, 53f),
                    });
                })
                .AddElement("left_wing", element => {
                    element.Part = "left_wing";
                    element.Translate = new Vector3(12f, -19f, -2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-68f, 15f, -2f),
                        Size = new Vector3(56f, 8f, 8f),
                        UV = new Vector2(112f, 88f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-68f, 19f, 4f),
                        Size = new Vector3(56f, 0f, 56f),
                        UV = new Vector2(-56f, 88f),
                    });
                })
                .AddElement("left_wing_tip", element => {
                    element.Part = "left_wing_tip";
                    element.Translate = new Vector3(68f, -19f, -2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-124f, 17f, 0f),
                        Size = new Vector3(56f, 4f, 4f),
                        UV = new Vector2(112f, 136f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-124f, 19f, 4f),
                        Size = new Vector3(56f, 0f, 56f),
                        UV = new Vector2(-56f, 144f),
                    });
                })
                .AddElement("right_wing", element => {
                    element.Part = "right_wing";
                    element.Translate = new Vector3(-12f, -19f, -2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(12f, 19f, 4f),
                        Size = new Vector3(56f, 0f, 56f),
                        UV = new Vector2(-56f, 88f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(12f, 15f, -2f),
                        Size = new Vector3(56f, 8f, 8f),
                        UV = new Vector2(112f, 88f),
                    });
                })
                .AddElement("right_wing_tip", element => {
                    element.Part = "right_wing_tip";
                    element.Translate = new Vector3(-68f, -19f, -2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(68f, 19f, 4f),
                        Size = new Vector3(56f, 0f, 56f),
                        UV = new Vector2(-56f, 144f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(68f, 17f, 0f),
                        Size = new Vector3(56f, 4f, 4f),
                        UV = new Vector2(112f, 136f),
                    });
                })
                .AddElement("front_left_leg", element => {
                    element.Part = "front_left_leg";
                    element.Translate = new Vector3(12f, -4f, -2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-16f, -16f, -2f),
                        Size = new Vector3(8f, 24f, 8f),
                        UV = new Vector2(112f, 104f),
                    });
                })
                .AddElement("front_left_shin", element => {
                    element.Part = "front_left_shin";
                    element.Translate = new Vector3(12f, 17f, -2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-15f, -40f, -1f),
                        Size = new Vector3(6f, 24f, 6f),
                        UV = new Vector2(226f, 138f),
                    });
                })
                .AddElement("front_left_foot", element => {
                    element.Part = "front_left_foot";
                    element.Translate = new Vector3(11f, 40f, -2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-16f, -44f, -10f),
                        Size = new Vector3(8f, 4f, 16f),
                        UV = new Vector2(144f, 104f),
                    });
                })
                .AddElement("back_left_leg", element => {
                    element.Part = "back_left_leg";
                    element.Translate = new Vector3(16f, -8f, -42f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-24f, -20f, 34f),
                        Size = new Vector3(16f, 32f, 16f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("back_left_shin", element => {
                    element.Part = "back_left_shin";
                    element.Translate = new Vector3(16f, 22f, -36f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-22f, -52f, 36f),
                        Size = new Vector3(12f, 32f, 12f),
                        UV = new Vector2(196f, 0f),
                    });
                })
                .AddElement("back_left_foot", element => {
                    element.Part = "back_left_foot";
                    element.Translate = new Vector3(16f, 52f, -44f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-25f, -58f, 24f),
                        Size = new Vector3(18f, 6f, 24f),
                        UV = new Vector2(112f, 0f),
                    });
                })
                .AddElement("front_right_leg", element => {
                    element.Part = "front_right_leg";
                    element.Translate = new Vector3(-12f, -4f, -2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(8f, -16f, -2f),
                        Size = new Vector3(8f, 24f, 8f),
                        UV = new Vector2(112f, 104f),
                    });
                })
                .AddElement("front_right_shin", element => {
                    element.Part = "front_right_shin";
                    element.Translate = new Vector3(-12f, 17f, -2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(9f, -40f, -1f),
                        Size = new Vector3(6f, 24f, 6f),
                        UV = new Vector2(226f, 138f),
                    });
                })
                .AddElement("front_right_foot", element => {
                    element.Part = "front_right_foot";
                    element.Translate = new Vector3(-12f, 40f, -2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(8f, -44f, -10f),
                        Size = new Vector3(8f, 4f, 16f),
                        UV = new Vector2(144f, 104f),
                    });
                })
                .AddElement("back_right_leg", element => {
                    element.Part = "back_right_leg";
                    element.Translate = new Vector3(-16f, -8f, -42f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(8f, -20f, 34f),
                        Size = new Vector3(16f, 32f, 16f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("back_right_shin", element => {
                    element.Part = "back_right_shin";
                    element.Translate = new Vector3(-16f, 22f, -36f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(10f, -52f, 36f),
                        Size = new Vector3(12f, 32f, 12f),
                        UV = new Vector2(196f, 0f),
                    });
                })
                .AddElement("back_right_foot", element => {
                    element.Part = "back_right_foot";
                    element.Translate = new Vector3(-16f, 52f, -44f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(7f, -58f, 24f),
                        Size = new Vector3(18f, 6f, 24f),
                        UV = new Vector2(112f, 0f),
                    });
                });
        }
    }
}
