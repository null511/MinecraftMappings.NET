using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Cat : JavaEntityModel
    {
        public Cat() : base("Cat")
        {
            AddVersion("cat", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -9f, 9f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2.5f, 7f, -12f),
                        Size = new Vector3(5f, 4f, 5f),
                        UV = Vector2.Zero,
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1.5f, 7.02f, -13f),
                        Size = new Vector3(3f, 2f, 2f),
                        UV = new Vector2(0f, 24f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1f, 11f, -9f),
                        Size = new Vector3(1f, 1f, 2f),
                        UV = new Vector2(0f, 10f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, 11f, -9f),
                        Size = new Vector3(1f, 1f, 2f),
                        UV = new Vector2(6, 10f),
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -12.1f, 10f);
                    element.RotationAngleX = -90;
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, -6.9f, -18f),
                        Size = new Vector3(4f, 16f, 6f),
                        UV = new Vector2(20, 0f),
                    });
                })
                .AddElement("front_left_leg", element => {
                    element.Part = "front_left_leg";
                    element.Translate = new Vector3(1.1f, -10f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2.1f, 0f, -5f),
                        Size = new Vector3(2f, 10f, 2f),
                        UV = new Vector2(40f, 0f),
                    });
                })
                .AddElement("front_right_leg", element => {
                    element.Part = "front_right_leg";
                    element.Translate = new Vector3(-1.1f, -10f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0.1f, 0f, -5f),
                        Size = new Vector3(2f, 10f, 2f),
                        UV = new Vector2(40f, 0f),
                    });
                })
                .AddElement("back_left_leg", element => {
                    element.Part = "back_left_leg";
                    element.Translate = new Vector3(1.1f, -6f, -5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2.1f, 0f, 6f),
                        Size = new Vector3(2f, 6f, 2f),
                        UV = new Vector2(8f, 13f),
                    });
                })
                .AddElement("back_right_leg", element => {
                    element.Part = "back_right_leg";
                    element.Translate = new Vector3(-1.1f, -6f, -5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0.1f, 0f, 6f),
                        Size = new Vector3(2f, 6f, 2f),
                        UV = new Vector2(8f, 13f),
                    });
                })
                .AddElement("tail", element => {
                    element.Part = "tail";
                    element.Translate = new Vector3(0f, -9.5f, -9f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-0.5f, 1.5f, 9f),
                        Size = new Vector3(1f, 8f, 1f),
                        UV = new Vector2(0f, 15f),
                    });
                })
                .AddElement("tail2", element => {
                    element.Part = "tail2";
                    element.Translate = new Vector3(0f, -1.5f, -9f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-0.5f, -6.5f, 9f),
                        Size = new Vector3(1f, 8f, 1f),
                        UV = new Vector2(4f, 15f),
                    });
                });
        }
    }
}
