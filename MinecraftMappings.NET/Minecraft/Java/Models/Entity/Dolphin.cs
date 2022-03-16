using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Dolphin : JavaEntityModel
    {
        public Dolphin() : base("Dolphin")
        {
            AddVersion("dolphin", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -4f, 6f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 0f, -9f),
                        Size = new Vector3(8f, 7f, 6f),
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, 0f, 3f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 0f, -13f),
                        Size = new Vector3(2f, 2f, 4f),
                        UV = new Vector2(0f, 13f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 0f, -3f),
                        Size = new Vector3(8f, 7f, 13f),
                        UV = new Vector2(22f, 0f),
                    });
                })
                .AddElement("tail", element => {
                    element.Part = "tail";
                    element.Translate = new Vector3(0f, -2.5f, -11f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, 0f, 10f),
                        Size = new Vector3(4f, 5f, 11f),
                        UV = new Vector2(0f, 19f),
                    });
                })
                .AddElement("right_fin", element => {
                    element.Part = "right_fin";
                    element.Translate = new Vector3(-4.5f, 0f, 2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(4f, 0f, -2f),
                        Size = new Vector3(1f, 4f, 7f),
                        UV = new Vector2(48f, 20f),
                    });
                })
                .AddElement("left_fin", element => {
                    element.Part = "left_fin";
                    element.Translate = new Vector3(4.5f, 0f, 2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 0f, -2f),
                        Size = new Vector3(1f, 4f, 7f),
                        UV = new Vector2(48f, 20f),
                    });
                })
                .AddElement("back_fin", element => {
                    element.Part = "back_fin";
                    element.Translate = new Vector3(0f, -11f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-0.5f, 7f, 3f),
                        Size = new Vector3(1f, 4f, 5f),
                        UV = new Vector2(51f, 0f),
                    });
                })
                .AddElement("tail_fin", element => {
                    element.Part = "tail_fin";
                    element.Translate = new Vector3(0f, -2.5f, -20f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 2f, 19f),
                        Size = new Vector3(10f, 1f, 6f),
                        UV = new Vector2(19f, 20f),
                    });
                });
        }
    }
}
