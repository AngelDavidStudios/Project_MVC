<script setup lang="ts">
import HeroesForm from '@/components/HeroesForm.vue'
import HeroesList from '@/components/HeroesList.vue'
import type { Hero } from '@/types/Hero.ts'
import { useHeroes } from '@/composables/useHeroes.ts'

const { selectedHero } = useHeroes()

const handleEdit = (hero: Hero) => {
  selectedHero.value = hero
}

const resetSelectedHero = () => {
  selectedHero.value = null
}


</script>

<template>
  <div class="min-h-screen bg-gradient-to-br from-blue-950 via-green-900 to-blue-950 p-8">
    <div class="max-w-6xl mx-auto">

      <!-- Header -->
      <header class="text-center mb-12">
        <h1 class="text-4xl font-bold text-white mb-2">My Hero Academia</h1>
        <p class="text-gray-300">Sistema de Gestión de Héroes</p>
      </header>

      <!-- Form Section -->
      <HeroesForm :hero="selectedHero"
                  @cancelEdit="resetSelectedHero"/>

      <!-- Heroes List -->
      <heroes-list @editHero="handleEdit"/>

    </div>

  </div>
</template>
