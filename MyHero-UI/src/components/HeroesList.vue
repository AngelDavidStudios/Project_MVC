<script setup lang="ts">

import type { Hero, HeroId } from '@/types/Hero.ts'

const props = defineProps<{
  hero: Hero[]
  onDelete: (id: HeroId) => Promise<void>
}>()
const emit = defineEmits<{
  (e: 'editHero', hero: Hero): void
  (e: 'deleted'): void
}>()

const editHero = (hero: Hero) => {
  emit('editHero', hero)
}

const confirmDelete = async (hero: Hero) => {
  const isConfirmed = confirm(`¿Estás seguro de eliminar a ${hero.name}?`)
  if (isConfirmed) {
    await props.onDelete(hero.id)
    emit('deleted')
  }
}

</script>

<template>
  <div class="bg-white/10 backdrop-blur-lg rounded-xl p-6">
    <h2 class="text-2xl font-semibold text-white mb-6">Lista de Héroes</h2>
    <div class="overflow-x-auto">
      <table class="w-full">
        <thead>
        <tr class="text-left border-b border-white/20">
          <th class="pb-4 text-gray-300">Nombre</th>
          <th class="pb-4 text-gray-300">Alias</th>
          <th class="pb-4 text-gray-300">Poder</th>
          <th class="pb-4 text-gray-300">Nivel</th>
          <th class="pb-4 text-gray-300">Estado</th>
          <th class="pb-4 text-gray-300">Acciones</th>
        </tr>
        </thead>
        <tbody>
        <tr v-for="hero in props.hero "
            :key="hero.id"
            class="border-b border-white/10">
          <td class="py-4 text-white">{{ hero.name }}</td>
          <td class="py-4 text-white">{{ hero.alias }}</td>
          <td class="py-4 text-white">{{ hero.power }}</td>
          <td class="py-4 text-white">{{ hero.level }}</td>
          <td class="py-4">
                  <span :class="hero.isAlive ? 'bg-green-500' : 'bg-red-500'" class="px-2 py-1 rounded-full text-xs text-white">
                    {{ hero.isAlive ? 'Activo' : 'Inactivo' }}
                  </span>
          </td>
          <td class="py-4">
            <div class="flex gap-2">
              <button
                @click="editHero(hero)"
                class="p-2 rounded-lg bg-blue-700 text-white hover:bg-blue-600 transition-colors"
              >
                Editar
              </button>
              <button
                @click="confirmDelete(hero)"
                class="p-2 rounded-lg bg-orange-500 text-white hover:bg-orange-400 transition-colors"
              >
                Eliminar
              </button>
            </div>
          </td>
        </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>
