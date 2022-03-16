using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Bee : JavaEntityModel
    {
        public Bee() : base("Bee")
        {
            AddVersion("bee", "1.15")
                .WithTextureSize(64, 64)
                .AddElement("body", element => {
                    element.Part = "body";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("left_wing", element => {
                    element.Part = "left_wing";
                    element.Translate = new Vector3(1.5f, -9f, 3f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-10.5f, 9f, -3f),
                        Size = new Vector3(9f, 0f, 6f),
                        UV = new Vector2(0f, 18f),
                    });
                })
                .AddElement("right_wing", element => {
                    element.Part = "right_wing";
                    element.Translate = new Vector3(-1.5f, -9f, 3f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1.5f, 9f, -3f),
                        Size = new Vector3(9f, 0f, 6f),
                        UV = new Vector2(0f, 18f),
                    });
                })
                .AddElement("front_legs", element => {
                    element.Part = "front_legs";
                    element.Translate = new Vector3(1.5f, -2f, 2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1.5f, 0f, -2f),
                        Size = new Vector3(3f, 2f, 0f),
                        UV = new Vector2(28f, 1f),
                    });
                })
                .AddElement("middle_legs", element => {
                    element.Part = "middle_legs";
                    element.Translate = new Vector3(1.5f, -2f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2.5f, 0f, 0f),
                        Size = new Vector3(5f, 2f, 0f),
                        UV = new Vector2(27f, 3f),
                    });
                })
                .AddElement("back_legs", element => {
                    element.Part = "back_legs";
                    element.Translate = new Vector3(1.5f, -2f, -2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2.5f, 0f, 2f),
                        Size = new Vector3(5f, 2f, 0f),
                        UV = new Vector2(27f, 5f),
                    });
                })
                .AddElement("left_antenna", element => {
                    element.Part = "left_antenna";
                    element.Translate = new Vector3(0f, -7f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2.5f, 7f, -8f),
                        Size = new Vector3(1f, 2f, 3f),
                        UV = new Vector2(2f, 0f),
                    });
                })
                .AddElement("stinger", element => {
                    element.Part = "stinger";
                    element.Translate = new Vector3(0f, -5f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 5f, 5f),
                        Size = new Vector3(0f, 1f, 2f),
                        UV = new Vector2(24f, 7f),
                    });
                })
                .AddElement("right_antenna", element => {
                    element.Part = "right_antenna";
                    element.Translate = new Vector3(0f, -7f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1.5f, 7f, -8f),
                        Size = new Vector3(1f, 2f, 3f),
                        UV = new Vector2(2f, 3f),
                    });
                })
                .AddElement("torso", element => {
                    element.Part = "torso";
                    element.Translate = new Vector3(0f, -5f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3.5f, 2f, -5f),
                        Size = new Vector3(7f, 7f, 10f),
                        UV = new Vector2(0f, 0f),
                    });
                });
        }
    }
}
