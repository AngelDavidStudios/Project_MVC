<script setup lang="ts">

import { useHeroes } from '@/composables/useHeroes.ts'

const { heroes } = useHeroes()

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
        <tr v-for="hero in heroes"
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

                class="p-2 rounded-lg bg-blue-700 text-white hover:bg-blue-600 transition-colors"
              >
                Editar
              </button>
              <button

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
