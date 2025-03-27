import type { Hero } from '@/types/Hero.ts'
import { ref } from 'vue'
import { createHero, deleteHero, getHeroes, updateHero } from '@/api/HeroAPI.ts'


export const useHeroes = () => {
  const heroes = ref<Hero[]>([]);
  const selectedHero = ref<Hero | null>(null);
  const loading = ref(false);
  const error = ref<string | null>(null);

  const fetchHeroes = async () => {
    try {
      loading.value = true;
      heroes.value = await getHeroes();
    }
    catch (e) {
      error.value = 'Error al cargar los héroes';
      console.error(e);
    }
    finally {
      loading.value = false;
    }
  };

  const saveHero = async (hero: Hero) => {
    try {
      loading.value = true;
      await createHero(hero);
      await fetchHeroes();
    }
    catch (e) {
      error.value = 'Error al guardar el héroe';
      console.error(e);
    }
    finally {
      loading.value = false;
    }
  };

  const patchHero = async (id: number, hero: Partial<Hero>) => {
    try {
      loading.value = true;
      await updateHero(id, hero);
      await fetchHeroes();
    }
    catch (e) {
      error.value = 'Error al actualizar el héroe';
      console.error(e);
    }
    finally {
      loading.value = false;
    }
  };

  const removeHero = async (id: number) => {
    try {
      loading.value = true;
      await deleteHero(id);
      await fetchHeroes();
    }
    catch (e) {
      error.value = 'Error al eliminar el héroe';
      console.error(e);
    }
    finally {
      loading.value = false;
    }
  }



  return {
    heroes,
    selectedHero,
    loading,
    error,
    fetchHeroes,
    saveHero,
    patchHero,
    removeHero
  }
}
