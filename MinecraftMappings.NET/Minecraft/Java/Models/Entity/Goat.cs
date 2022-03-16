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
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -19f, -2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement("rotation") {
                        Translate = new Vector3(0f, 19f, 2f),
                        RotationAngleX = -90f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-4f, -6f, -7f),
                                Size = new Vector3(8f, 16f, 6f),
                                UV = new Vector2(28f, 8f),
                            },
                        },
                    });
                })
                .AddElement("leg1", element => {
                    element.Part = "leg1";
                    element.Translate = new Vector3(-3f, -12f, -7f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1f, 0f, 5f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("leg2", element => {
                    element.Part = "leg2";
                    element.Translate = new Vector3(3f, -12f, -7f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 0f, 5f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("leg3", element => {
                    element.Part = "leg3";
                    element.Translate = new Vector3(-3f, -12f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1f, 0f, -7f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("leg4", element => {
                    element.Part = "leg4";
                    element.Translate = new Vector3(3f, -12f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 0f, -7f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                });
        }
    }
}
