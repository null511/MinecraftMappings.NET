using SharpDX;

namespace MinecraftMappings.Internal.Models
{
    public class ModelFace
    {
        public string? Texture;
        public RectangleF? UV;
        public int? Rotation;


        public ModelFace() {}

        public ModelFace(string texture)
        {
            Texture = texture;
        }

        public ModelFace(string texture, RectangleF uv)
        {
            Texture = texture;
            UV = uv;
        }

        //public ModelFace()
        //{
        //    UV = new RectangleF(0f, 0f, 16f, 16f);
        //}
    }
}
