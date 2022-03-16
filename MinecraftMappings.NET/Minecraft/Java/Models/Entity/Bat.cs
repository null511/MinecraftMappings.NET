using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Bat : JavaEntityModel
    {
        public Bat() : base("Bat")
        {
            AddVersion("bat", "1.4.2")
                .WithTextureSize(64, 64)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -23f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "right_ear",
                        //Translate = new Vector3(0f, 0f, 0f),
                        InvertAxisX = true,
                        InvertAxisY = true,
                        MirrorTexU = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-4f, 25f, -2f),
                                Size = new Vector3(3f, 4f, 1f),
                                UV = new Vector2(24f, 0f),
                            },
                        },
                    });

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 20f, -3f),
                        Size = new Vector3(6f, 6f, 6f),
                        UV = new Vector2(0f, 0f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1f, 25f, -2f),
                        Size = new Vector3(3f, 4f, 1f),
                        UV = new Vector2(24f, 0f),
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, 24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 8f, -3f),
                        Size = new Vector3(6f, 12f, 6f),
                        UV = new Vector2(0f, 16f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, -8f, 0f),
                        Size = new Vector3(10f, 16f, 1f),
                        UV = new Vector2(0f, 34f),
                    });
                })
                .AddElement("right_wing", element => {
                    element.Part = "right_wing";
                    element.Translate = new Vector3(0f, 24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(2f, 7f, 1.5f),
                        Size = new Vector3(10f, 16f, 1f),
                        UV = new Vector2(42f, 0f),
                    });
                })
                .AddElement("left_wing", element => {
                    element.Part = "left_wing";
                    element.Translate = new Vector3(0f, 24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-12f, 7f, 1.5f),
                        Size = new Vector3(10f, 16f, 1f),
                        UV = new Vector2(42f, 0f),
                    });
                })
                .AddElement("outer_right_wing", element => {
                    element.Part = "outer_right_wing";
                    element.Translate = new Vector3(-12f, 23f, 1.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(12f, 10f, 1.5f),
                        Size = new Vector3(8f, 12f, 1f),
                        UV = new Vector2(24f, 16f),
                    });
                })
                .AddElement("outer_left_wing", element => {
                    element.Part = "outer_left_wing";
                    element.Translate = new Vector3(12f, 23f, 1.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-20f, 10f, 1.5f),
                        Size = new Vector3(8f, 12f, 1f),
                        UV = new Vector2(24f, 16f),
                    });
                });
        }
    }
}
