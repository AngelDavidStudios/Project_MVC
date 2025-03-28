<script setup lang="ts">
import { reactive, watch } from 'vue'
import type { Hero, HeroId } from '@/types/Hero.ts'

const props = defineProps<{
  hero: Hero | null
  onSave: (hero: Hero) => Promise<void>
  onUpdate: (id: HeroId, hero: Partial<Hero>) => Promise<void>
}>()

const emit = defineEmits<{
  (e: 'cancelEdit'): void
  (e: 'saved'): void
  (e: 'updated'): void
}>()

const initialData = {
  id: '',
  name: '',
  alias: '',
  power: '',
  level: 1,
  isAlive: true,
  description: '',
}

const formData = reactive({ ...initialData })

const resetForm = () => {
  Object.assign(formData, initialData)
  emit('cancelEdit')
}

watch(
  () => props.hero,
  (newHero) => {
    if (newHero) {
      Object.assign(formData, newHero)
    } else {
      resetForm()
    }
  },
  { immediate: true }
)

const handleSubmit = async () => {
  if (props.hero) {
    await props.onUpdate(props.hero.id, formData)
    emit('updated')
  } else {
    await props.onSave(formData)
    emit('saved')
  }
  resetForm()
}
</script>

<template>
  <div class="bg-white/10 backdrop-blur-lg rounded-xl p-6 mb-8">
    <h2 class="text-2xl font-semibold text-white mb-6">Agregar Heroe</h2>
    <form @submit.prevent="handleSubmit" class="grid grid-cols-1 md:grid-cols-2 gap-6">
      <div>
        <label class="block text-gray-300 mb-2">Nombre</label>
        <input
          v-model="formData.name"
          type="text"
          class="w-full bg-white/5 border border-white/20 rounded-lg px-4 py-2 text-white focus:outline-none focus:border-hero-tomato"
          required
        />
      </div>
      <div>
        <label class="block text-gray-300 mb-2">Alias</label>
        <input
          v-model="formData.alias"
          type="text"
          class="w-full bg-white/5 border border-white/20 rounded-lg px-4 py-2 text-white focus:outline-none focus:border-hero-tomato"
          required
        />
      </div>
      <div>
        <label class="block text-gray-300 mb-2">Poder</label>
        <input
          v-model="formData.power"
          type="text"
          class="w-full bg-white/5 border border-white/20 rounded-lg px-4 py-2 text-white focus:outline-none focus:border-hero-tomato"
          required
        />
      </div>
      <div>
        <label class="block text-gray-300 mb-2">Nivel</label>
        <input
          v-model.number="formData.level"
          type="number"
          min="1"
          max="100"
          class="w-full bg-white/5 border border-white/20 rounded-lg px-4 py-2 text-white focus:outline-none focus:border-hero-tomato"
          required
        />
      </div>
      <div class="md:col-span-2">
        <label class="block text-gray-300 mb-2">Descripción</label>
        <textarea
          v-model="formData.description"
          class="w-full bg-white/5 border border-white/20 rounded-lg px-4 py-2 text-white focus:outline-none focus:border-hero-tomato"
          rows="3"
          required
        ></textarea>
      </div>
      <div class="md:col-span-2 flex items-center">
        <label class="flex items-center cursor-pointer">
          <input
            v-model="formData.isAlive"
            type="checkbox"
            class="form-checkbox h-5 w-5 text-hero-tomato rounded border-white/20 bg-white/5"
          />
          <span class="ml-2 text-gray-300">¿Está vivo?</span>
        </label>
      </div>
      <div class="md:col-span-2 flex justify-end gap-4">
        <button
          type="button"
          @click="resetForm"
          class="px-6 py-2 rounded-lg bg-white/10 text-white hover:bg-white/20 transition-colors"
        >
          Cancelar
        </button>
        <button
          type="submit"
          class="px-6 py-2 rounded-lg bg-orange-700 text-white hover:bg-orange-600 transition-colors"
        >
          {{ props.hero ? 'Actualizar' : 'Guardar' }}
        </button>
      </div>
    </form>
  </div>
</template>

<style scoped></style>
