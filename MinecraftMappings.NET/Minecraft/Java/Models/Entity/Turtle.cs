using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Turtle : JavaEntityModel
    {
        public Turtle() : base("Turtle")
        {
            AddVersion("turtle", "1.0.0")
                .WithTextureSize(128, 64)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -5f, 10f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 1f, -13f),
                        Size = new Vector3(6f, 5f, 6f),
                        UV = new Vector2(3f, 0f),
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -13f, 10f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "body_rotation",
                        Translate = new Vector3(0f, 13f, -10f),
                        RotationAngleX = -90,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-9.5f, -23f, -10f),
                                Size = new Vector3(19f, 20f, 6f),
                                UV = new Vector2(7f, 37f),
                            },
                            new EntityElementCube {
                                Position = new Vector3(-5.5f, -21f, -13f),
                                Size = new Vector3(11f, 18f, 3f),
                                UV = new Vector2(31f, 1f),
                            },
                        },
                    });
                })
                .AddElement("body2", element => {
                    element.Part = "body2";
                    element.Translate = new Vector3(0f, -13f, 10f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "body2_rotation",
                        Translate = new Vector3(0f, 13f, -10f),
                        RotationAngleX = -90,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-4.5f, -21f, -14f),
                                Size = new Vector3(9f, 18f, 1f),
                                UV = new Vector2(70f, 33f),
                            },
                        },
                    });
                })
                .AddElement("leg1", element => {
                    element.Part = "leg1";
                    element.Translate = new Vector3(-3.5f, -2f, -11f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1.5f, 1f, 11f),
                        Size = new Vector3(4f, 1f, 10f),
                        UV = new Vector2(1f, 23f),
                    });
                })
                .AddElement("leg2", element => {
                    element.Part = "leg2";
                    element.Translate = new Vector3(3.5f, -2f, -11f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5.5f, 1f, 11f),
                        Size = new Vector3(4f, 1f, 10f),
                        UV = new Vector2(1f, 12f),
                    });
                })
                .AddElement("leg3", element => {
                    element.Part = "leg3";
                    element.Translate = new Vector3(-5f, -3f, 4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(5f, 2f, -6f),
                        Size = new Vector3(13f, 1f, 5f),
                        UV = new Vector2(27f, 30f),
                    });
                })
                .AddElement("leg4", element => {
                    element.Part = "leg4";
                    element.Translate = new Vector3(5f, -3f, 4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-18f, 2f, -6f),
                        Size = new Vector3(13f, 1f, 5f),
                        UV = new Vector2(27f, 24f),
                    });
                });
        }
    }
}
