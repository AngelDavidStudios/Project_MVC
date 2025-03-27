import axios from 'axios'
import type { Hero } from '@/types/Hero.ts'


const heroAPI = axios.create({
  baseURL: 'http://localhost:5104/api'
})

export const getHeroes = async (): Promise<Hero[]> => {
  const response = await heroAPI.get('/Hero')
  return response.data;
}

export const createHero = async(hero: Hero): Promise<Hero[]> => {
  const response = await heroAPI.post('/Hero', hero)
  return response.data;
}

export const updateHero = async (id: number, hero: Partial<Hero>): Promise<Hero> => {
  const response = await heroAPI.put<Hero>(`/Hero/${id}`, hero);
  return response.data;
};

export const deleteHero = async (id: number): Promise<void> => {
  await heroAPI.delete(`/Hero/${id}`);
};
