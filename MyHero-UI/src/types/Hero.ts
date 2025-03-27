export interface Hero {
  id: string;
  name: string;
  alias: string;
  power: string;
  level: number;
  isAlive: boolean;
  description: string;
}

export type HeroId = Pick<Hero, 'id'>;
