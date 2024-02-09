using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Warden : JavaEntityModel
    {
        public Warden() : base("Warden")
        {
            AddVersion("warden", "1.19")
                .WithTextureSize(128, 128)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -34f, 1f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, 34f, -6f),
                        Size = new Vector3(16f, 16f, 10f),
                        UV = new Vector2(0f, 32f),
                    });
                })
                .AddElement("left_tendril", element => {
                    element.Part = "left_tendril";
                    element.Translate = new Vector3(8f, -46f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-24f, 43f, 0f),
                        Size = new Vector3(16f, 16f, 0f),
                        UV = new Vector2(58f, 0f),
                    });
                })
                .AddElement("right_tendril", element => {
                    element.Part = "right_tendril";
                    element.Translate = new Vector3(-8f, -46f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(8f, 43f, 0f),
                        Size = new Vector3(16f, 16f, 0f),
                        UV = new Vector2(52f, 32f),
                    });
                })
                .AddElement("torso", element => {
                    element.Part = "torso";
                    element.Translate = new Vector3(0f, -21f, 1f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-9f, 13f, -5f),
                        Size = new Vector3(18f, 21f, 11f),
                        UV = new Vector2(0f, 0f),
                    });
                })
                .AddElement("left_ribcage", element => {
                    element.Part = "left_ribcage";
                    element.Translate = new Vector3(7f, -23f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-9f, 13f, -5.1f),
                        Size = new Vector3(9f, 21f, 0f),
                        UV = new Vector2(90f, 11f),
                    });
                })
                .AddElement("right_ribcage", element => {
                    element.Part = "right_ribcage";
                    element.Translate = new Vector3(-7f, -23f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 13f, -5.1f),
                        Size = new Vector3(9f, 21f, 0f),
                        UV = new Vector2(90f, 11f),
                    });
                })
                .AddElement("left_arm", element => {
                    element.Part = "left_arm";
                    element.Translate = new Vector3(13f, -34f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-17f, 6f, -4f),
                        Size = new Vector3(8f, 28f, 8f),
                        UV = new Vector2(0f, 58f),
                    });
                })
                .AddElement("right_arm", element => {
                    element.Part = "right_arm";
                    element.Translate = new Vector3(-13f, -34f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(9f, 6f, -4f),
                        Size = new Vector3(8f, 28f, 8f),
                        UV = new Vector2(44f, 50f),
                    });
                })
                .AddElement("left_leg", element => {
                    element.Part = "left_leg";
                    element.Translate = new Vector3(6f, -13f, 1f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-9.1f, 0f, -4f),
                        Size = new Vector3(6f, 13f, 6f),
                        UV = new Vector2(76f, 76f),
                    });
                })
                .AddElement("right_leg", element => {
                    element.Part = "right_leg";
                    element.Translate = new Vector3(-6f, -13f, 1f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(3.1f, 0f, -4f),
                        Size = new Vector3(6f, 13f, 6f),
                        UV = new Vector2(76f, 48f),
                    });
                });
        }
    }
}
