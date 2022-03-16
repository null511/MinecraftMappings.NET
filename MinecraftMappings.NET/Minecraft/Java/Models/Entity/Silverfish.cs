using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Silverfish : JavaEntityModel
    {
        public Silverfish() : base("Silverfish")
        {
            AddVersion("silverfish", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("body1", element => {
                    element.Part = "body1";
                    element.Translate = new Vector3(0f, -2f, 7f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1.5f, 0f, -8f),
                        Size = new Vector3(3f, 2f, 2f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("body2", element => {
                    element.Part = "body2";
                    element.Translate = new Vector3(0f, -3f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, 0f, -6f),
                        Size = new Vector3(4f, 3f, 2f),
                        UV = new Vector2(0f, 4f),
                    });
                })
                .AddElement("body3", element => {
                    element.Part = "body3";
                    element.Translate = new Vector3(0f, -4f, 2.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 0f, -4f),
                        Size = new Vector3(6f, 4f, 3f),
                        UV = new Vector2(0f, 9f),
                    });
                })
                .AddElement("body4", element => {
                    element.Part = "body4";
                    element.Translate = new Vector3(0f, -3f, -0.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1.5f, 0f, -1f),
                        Size = new Vector3(3f, 3f, 3f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("body5", element => {
                    element.Part = "body5";
                    element.Translate = new Vector3(0f, -2f, -3.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 0f, 2f),
                        Size = new Vector3(2f, 2f, 3f),
                        UV = new Vector2(0f, 22f),
                    });
                })
                .AddElement("body6", element => {
                    element.Part = "body6";
                    element.Translate = new Vector3(0f, -1f, -6f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 0f, 5f),
                        Size = new Vector3(2f, 1f, 2f),
                        UV = new Vector2(11f, 0f),
                    });
                })
                .AddElement("body7", element => {
                    element.Part = "body7";
                    element.Translate = new Vector3(0f, -1f, -8f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-0.5f, 0f, 7f),
                        Size = new Vector3(1f, 1f, 2f),
                        UV = new Vector2(13f, 4f),
                    });
                })
                .AddElement("wing1", element => {
                    element.Part = "wing1";
                    element.Translate = new Vector3(0f, -8f, 2.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 0f, -4f),
                        Size = new Vector3(10f, 8f, 3f),
                        UV = new Vector2(20f, 0f),
                    });
                })
                .AddElement("wing2", element => {
                    element.Part = "wing2";
                    element.Translate = new Vector3(0f, -4f, -3.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 0f, 2f),
                        Size = new Vector3(6f, 4f, 3f),
                        UV = new Vector2(20f, 11f),
                    });
                })
                .AddElement("wing3", element => {
                    element.Part = "wing3";
                    element.Translate = new Vector3(0f, -5f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 0f, -6.5f),
                        Size = new Vector3(6f, 5f, 2f),
                        UV = new Vector2(20f, 18f),
                    });
                });
        }
    }
}
