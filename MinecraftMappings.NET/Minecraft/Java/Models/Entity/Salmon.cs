using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Salmon : JavaEntityModel
    {
        public Salmon() : base("Salmon")
        {
            AddVersion("salmon", "1.0.0")
                .WithTextureSize(32, 32)
                .AddElement("body_front", element => {
                    element.Part = "body_front";
                    element.Translate = new Vector3(0f, -6f, 4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1.5f, 3.5f, -4f),
                        Size = new Vector3(3f, 5f, 8f),
                        UV = Vector2.Zero,
                    });

                    element.Submodels.Add(new EntityElement {
                        Id = "right_fin",
                        Translate = new Vector3(1.5f, 4.5f, -3f),
                        RotationAngleX = 90f,
                        RotationAngleZ = -45f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(0f, -1f, 0f),
                                Size = new Vector3(2f, 2f, 0f),
                                UV = Vector2.Zero,
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "left_fin",
                        Translate = new Vector3(-1.5f, 4.5f, -3f),
                        RotationAngleX = 90,
                        RotationAngleZ = 45f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-2f, -1f, 0f),
                                Size = new Vector3(2f, 2f, 0f),
                                UV = new Vector2(4f, 0f),
                            },
                        },
                    });
                })
                .AddElement("body_back", element => {
                    element.Part = "body_back";
                    element.Translate = new Vector3(0f, -6f, -4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1.5f, 3.5f, 4f),
                        Size = new Vector3(3f, 5f, 8f),
                        UV = new Vector2(0f, 13f),
                    });
                })
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -6f, 4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 4f, -7f),
                        Size = new Vector3(2f, 4f, 3f),
                        UV = new Vector2(22f, 0f),
                    });
                })
                .AddElement("fin_back_1", element => {
                    element.Part = "fin_back_1";
                    element.Translate = new Vector3(0f, -10.5f, -1f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 8.5f, 2f),
                        Size = new Vector3(0f, 2f, 2f),
                        UV = new Vector2(4f, 2f),
                    });
                })
                .AddElement("fin_back_2", element => {
                    element.Part = "fin_back_2";
                    element.Translate = new Vector3(0f, -10.5f, -3f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 8.5f, 3f),
                        Size = new Vector3(0f, 2f, 4f),
                        UV = new Vector2(0f, 2f),
                    });
                })
                .AddElement("tail", element => {
                    element.Part = "tail";
                    element.Translate = new Vector3(0f, -6f, -12f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 3.5f, 12f),
                        Size = new Vector3(0f, 5f, 6f),
                        UV = new Vector2(20f, 10f),
                    });
                })
                .AddElement("fin_left", element => {
                    element.Part = "fin_left";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("fin_right", element => {
                    element.Part = "fin_right";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                });
        }
    }
}
