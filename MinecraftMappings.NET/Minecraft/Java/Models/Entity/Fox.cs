using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Fox : JavaEntityModel
    {
        public Fox() : base("Fox")
        {
            AddVersion("fox", "1.0.0")
                .WithTextureSize(48, 32)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(-1f, -7.5f, 3f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 3.5f, -8f),
                        Size = new Vector3(8f, 6f, 6f),
                        UV = new Vector2(1f, 5f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 9.5f, -7f),
                        Size = new Vector3(2f, 2f, 1f),
                        UV = new Vector2(15f, 1f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(2f, 9.5f, -7f),
                        Size = new Vector3(2f, 2f, 1f),
                        UV = new Vector2(8f, 1f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, 3.5f, -11f),
                        Size = new Vector3(4f, 2f, 3f),
                        UV = new Vector2(6f, 18f),
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -16.5f, -3.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "body_rotation",
                        Translate = new Vector3(0f, 7.5f, 3f),
                        RotationAngleX = -90,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-3f, -6f, -3f),
                                Size = new Vector3(6f, 11f, 6f),
                                UV = new Vector2(24f, 15f),
                            },
                        },
                    });
                })
                .AddElement("leg1", element => {
                    element.Part = "leg1";
                    element.Translate = new Vector3(-5f, -6.5f, -7f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1.001f, 0f, 6f),
                        Size = new Vector3(2f, 6f, 2f),
                        UV = new Vector2(13f, 24f),
                    });
                })
                .AddElement("leg2", element => {
                    element.Part = "leg2";
                    element.Translate = new Vector3(-1f, -6.5f, -7f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3.001f, 0f, 6f),
                        Size = new Vector3(2f, 6f, 2f),
                        UV = new Vector2(4f, 24f),
                    });
                })
                .AddElement("leg3", element => {
                    element.Part = "leg3";
                    element.Translate = new Vector3(-5f, -6.5f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1.001f, 0f, -1f),
                        Size = new Vector3(2f, 6f, 2f),
                        UV = new Vector2(13f, 24f),
                    });
                })
                .AddElement("leg4", element => {
                    element.Part = "leg4";
                    element.Translate = new Vector3(-1f, -6.5f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3.001f, 0f, -1f),
                        Size = new Vector3(2f, 6f, 2f),
                        UV = new Vector2(4f, 24f),
                    });
                })
                .AddElement("tail", element => {
                    element.Part = "tail";
                    element.Translate = new Vector3(-4f, -11f, -10f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "tail_rotation",
                        Translate = new Vector3(0f, 8.5f, 11.5f),
                        RotationAngleX = -90,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-2f, -6.5f, -2.5f),
                                Size = new Vector3(4f, 9f, 5f),
                                UV = new Vector2(30f, 0f),
                            },
                        },
                    });
                });
        }
    }
}
