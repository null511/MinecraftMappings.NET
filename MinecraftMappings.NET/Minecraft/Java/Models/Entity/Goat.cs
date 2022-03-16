using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Goat : JavaEntityModel
    {
        public Goat() : base("Goat")
        {
            AddVersion("goat", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0.5f, -10f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 6f, -14f),
                        Size = new Vector3(0f, 7f, 5f),
                        UV = new Vector2(23f, 52f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(2.5f, 19f, -10f),
                        Size = new Vector3(3f, 2f, 1f),
                        UV = new Vector2(2f, 61f),
                    });

                    element.Submodels.Add(new EntityElement {
                        Id = "mirror",
                        InvertAxisX = true,
                        InvertAxisY = true,
                        MirrorTexU = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-5.5f, 19f, -10f),
                                Size = new Vector3(3f, 2f, 1f),
                                UV = new Vector2(2f, 61f),
                            },
                        },
                    });
                })
                .AddElement("nose", element => {
                    element.Part = "nose";
                    element.Translate = new Vector3(0.5f, -18f, 8f);
                    element.RotationAngleX = -55;
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2.5f, 15f, -16f),
                        Size = new Vector3(5f, 7f, 10f),
                        UV = new Vector2(34f, 46f),
                    });
                })
                .AddElement("left_horn", element => {
                    element.Part = "left_horn";
                    element.Translate = new Vector3(0.5f, -10f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2.49f, 19f, -10f),
                        Size = new Vector3(2f, 7f, 2f),
                        UV = new Vector2(12f, 55f),
                    });
                })
                .AddElement("right_horn", element => {
                    element.Part = "right_horn";
                    element.Translate = new Vector3(0.5f, -10f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0.49f, 19f, -10f),
                        Size = new Vector3(2f, 7f, 2f),
                        UV = new Vector2(12f, 55f),
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(-0.5f, 0f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4.5f, 6f, -7f),
                        Size = new Vector3(9f, 11f, 16f),
                        UV = new Vector2(1f, 1f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5.5f, 4f, -8f),
                        Size = new Vector3(11f, 14f, 11f),
                        UV = new Vector2(0f, 28f),
                    });
                })
                .AddElement("leg1", element => {
                    element.Part = "leg1";
                    element.Translate = new Vector3(-3.5f, -10f, -4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0.5f, 0f, 4f),
                        Size = new Vector3(3f, 6f, 3f),
                        UV = new Vector2(49f, 29f),
                    });
                })
                .AddElement("leg2", element => {
                    element.Part = "leg2";
                    element.Translate = new Vector3(0.5f, -10f, -4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3.5f, 0f, 4f),
                        Size = new Vector3(3f, 6f, 3f),
                        UV = new Vector2(36f, 29f),
                    });
                })
                .AddElement("leg3", element => {
                    element.Part = "leg3";
                    element.Translate = new Vector3(-3.5f, -10f, 6f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0.5f, 0f, -6f),
                        Size = new Vector3(3f, 10f, 3f),
                        UV = new Vector2(49f, 2f),
                    });
                })
                .AddElement("leg4", element => {
                    element.Part = "leg4";
                    element.Translate = new Vector3(0.5f, -10f, 6f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3.5f, 0f, -6f),
                        Size = new Vector3(3f, 10f, 3f),
                        UV = new Vector2(35f, 2f),
                    });
                });
        }
    }
}
