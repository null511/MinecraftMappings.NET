using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TripwireAttachedN : JavaBlockModel
    {
        public TripwireAttachedN() : base("Tripwire Attached, North")
        {
            AddVersion("tripwire_attached_n", "1.0.0")
                .WithPath("models/block")
                .AddTexture("texture", "block/tripwire")
                .AddElement(element => {
                    element.From = new Vector3(7.75f, 1.5f, 0f);
                    element.To = new Vector3(8.25f, 1.5f, 4f);
                    element.FaceUp = new ModelFace("#texture") {
                        UV = UVMap(0f, 2f, 16f, 4f),
                        Rotation = 90,
                    };
                    element.FaceDown = new ModelFace("#texture") {
                        UV = UVMap(16f, 2f, 0f, 4f),
                        Rotation = 90,
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7.75f, 1.5f, 4f);
                    element.To = new Vector3(8.25f, 1.5f, 8f);
                    element.FaceUp = new ModelFace("#texture") {
                        UV = UVMap(0f, 2f, 16f, 4f),
                        Rotation = 90,
                    };
                    element.FaceDown = new ModelFace("#texture") {
                        UV = UVMap(16f, 2f, 0f, 4f),
                        Rotation = 90,
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(7.75f, 1.5f, 8f);
                    element.To = new Vector3(8.25f, 1.5f, 12f);
                    element.FaceUp = new ModelFace("#texture") {
                        UV = UVMap(0f, 2f, 16f, 4f),
                        Rotation = 90,
                    };
                    element.FaceDown = new ModelFace("#texture") {
                        UV = UVMap(16f, 2f, 0f, 4f),
                        Rotation = 90,
                    };
                });
        }
    }
}
