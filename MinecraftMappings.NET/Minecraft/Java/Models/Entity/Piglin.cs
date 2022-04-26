using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Piglin : JavaEntityModel
    {
        public Piglin() : base("Piglin")
        {
            AddVersion("piglin", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 24f, -4f),
                        Size = new Vector3(10f, 8f, 8f),
                        UV = Vector2.Zero,
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, 24f, -5f),
                        Size = new Vector3(4f, 4f, 1f),
                        UV = new Vector2(31f, 1f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 24f, -5f),
                        Size = new Vector3(1f, 2f, 1f),
                        UV = new Vector2(2f, 4f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(2f, 24f, -5f),
                        Size = new Vector3(1f, 2f, 1f),
                        UV = new Vector2(2f, 0f),
                    });
                })
                .AddElement("headwear", element => {
                    element.Part = "headwear";
                    element.Translate = Vector3.Zero;
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("left_ear", element => {
                    element.Part = "left_ear";
                    element.Translate = new Vector3(5f, -30f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 25f, -2f),
                        Size = new Vector3(1f, 5f, 4f),
                        UV = new Vector2(51f, 6f),
                    });
                })
                .AddElement("right_ear", element => {
                    element.Part = "right_ear";
                    element.Translate = new Vector3(-5f, -30f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(5f, 25f, -2f),
                        Size = new Vector3(1f, 5f, 4f),
                        UV = new Vector2(39f, 6f),
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 12f, -2f),
                        Size = new Vector3(8f, 12f, 4f),
                        UV = new Vector2(16f, 16f),
                    });
                })
                .AddElement("jacket", element => {
                    element.Part = "jacket";
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 12f, -2f),
                        Size = new Vector3(8f, 12f, 4f),
                        UV = new Vector2(16f, 32f),
                        SizeAdd = 0.25f,
                    });
                })
                .AddElement("left_arm", element => {
                    element.Part = "left_arm";
                    element.Translate = new Vector3(5f, -22f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, 12f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(32f, 48f),
                    });
                })
                .AddElement("left_sleeve", element => {
                    element.Part = "left_sleeve";
                    element.Translate = new Vector3(5f, -22f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, 12f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(48f, 48f),
                        SizeAdd = 0.25f,
                    });
                })
                .AddElement("right_arm", element => {
                    element.Part = "right_arm";
                    element.Translate = new Vector3(-5f, -22f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(4f, 12f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(40f, 16f),
                    });
                })
                .AddElement("right_sleeve", element => {
                    element.Part = "right_sleeve";
                    element.Translate = new Vector3(-5f, -22f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(4f, 12f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(40f, 32f),
                        SizeAdd = 0.25f,
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
                        UV = new Vector2(16f, 48f),
                    });
                })
                .AddElement("left_pants", element => {
                    element.Part = "left_pants";
                    element.Translate = new Vector3(2f, -12f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 0f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 48f),
                        SizeAdd = 0.25f,
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
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("right_pants", element => {
                    element.Part = "right_pants";
                    element.Translate = new Vector3(-2f, -12f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 0f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 32f),
                        SizeAdd = 0.25f,
                    });
                });
        }
    }
}
