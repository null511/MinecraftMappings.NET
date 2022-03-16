using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Enderman : JavaEntityModel
    {
        public Enderman() : base("Enderman")
        {
            AddVersion("enderman", "1.8")
                .WithTextureSize(64, 32)
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -39f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 27f, -2f),
                        Size = new Vector3(8f, 12f, 4f),
                        UV = new Vector2(32f, 16f),
                    });
                })
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -39f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 39f, -4f),
                        Size = new Vector3(8f, 8f, 8f),
                        UV = new Vector2(0f, 0f),
                    });
                })
                .AddElement("headwear", element => {
                    element.Part = "headwear";
                    element.Translate = new Vector3(0f, -39f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 39f, -4f),
                        Size = new Vector3(8f, 8f, 8f),
                        UV = new Vector2(0f, 16f),
                        SizeAdd = -0.5f,
                    });
                })
                .AddElement("right_arm", element => {
                    element.Part = "right_arm";
                    element.Translate = new Vector3(-5f, -37f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(4f, 9f, -1f),
                        Size = new Vector3(2f, 30f, 2f),
                        UV = new Vector2(56f, 0f),
                    });
                })
                .AddElement("left_arm", element => {
                    element.Part = "left_arm";
                    element.Translate = new Vector3(5f, -37f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 9f, -1f),
                        Size = new Vector3(2f, 30f, 2f),
                        UV = new Vector2(56f, 0f),
                    });
                })
                .AddElement("right_leg", element => {
                    element.Part = "right_leg";
                    element.Translate = new Vector3(-2f, -30f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1f, 0f, -1f),
                        Size = new Vector3(2f, 30f, 2f),
                        UV = new Vector2(56f, 0f),
                    });
                })
                .AddElement("left_leg", element => {
                    element.Part = "left_leg";
                    element.Translate = new Vector3(2f, -30f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 0f, -1f),
                        Size = new Vector3(2f, 30f, 2f),
                        UV = new Vector2(56f, 0f),
                    });
                });
        }
    }
}
