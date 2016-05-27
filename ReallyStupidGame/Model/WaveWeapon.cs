using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ReallyStupidGame.Model
{
	public class WaveWeapon
	{
		private Texture2D texture;
		private int damage;
		private float waveSpeed;
		private Vector2 position;
		private Viewport viewport;
		private bool active;

		public bool Active
		{
			get { return active;}
			set {active = value; }
		}

		public Texture2D Texture
		{
			get { return texture; }
			set { texture = value; }
		}

		public int Damage
		{
			get { return damage; }
			set { damage = value; }
		}

		public float WaveSpeed
		{
			get { return waveSpeed; }
			set { waveSpeed = value; }
		}

		public Vector2 Position
		{
			get { return position; }
			set { position = value; }
		}


		public void Initialize(Viewport viewPort, Texture2D texture, Vector2 position)
		{
			this.viewport = viewport;
			this.texture = texture;
			this.damage = 5000;
			this.position = position;
			this.waveSpeed = .25f;
			this.Active = true;
		}

		public void Update()
		{
			position.X += waveSpeed;
			position.Y += .025f;
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(texture, position, null, Color.White, position.Y*3, Vector2.Zero, 2f, SpriteEffects.None, 0f);

		}
	}
}

