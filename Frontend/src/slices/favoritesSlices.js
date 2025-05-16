/**
 * Este archivo define un slice de Redux llamado "favorites" usando Redux Toolkit.
 * 
 * - Se importa `createSlice` desde `@reduxjs/toolkit`, lo que permite crear slices
 *   de forma concisa, incluyendo estado, reducers y actions en un solo lugar.
 * 
 * - `favoritesSlices`:
 *   - `name`: Es el nombre del slice, usado para identificarlo en el store global.
 *   - `initialState`: Se establece como un array vacío, representando una lista de IDs de productos marcados como favoritos.
 *   - `reducers`: Define las funciones que pueden modificar el estado:
 * 
 *     - `addFavorite`: 
 *       - Agrega un ID al estado solo si no está ya presente.
 *       - Usa `state.push` para añadir el ID al array.
 * 
 *     - `removeFavorite`:
 *       - Elimina un ID del estado.
 *       - Retorna un nuevo array filtrando el ID a eliminar, cumpliendo con el principio de inmutabilidad.
 * 
 * - Se exportan las acciones (`addFavorite`, `removeFavorite`) para que puedan ser usadas en los componentes.
 * - Se exporta el `reducer` por defecto, el cual será utilizado para integrarlo al store principal de Redux.
 * 
 * Este enfoque modular facilita la gestión del estado global de favoritos en la aplicación,
 * permitiendo agregar o quitar favoritos desde cualquier parte del frontend de forma coherente.
 */

import { createSlice } from '@reduxjs/toolkit'

const favoritesSlices = createSlice({
  name: 'favorites',
  initialState: [],
  reducers: {
    addFavorite: (state, action) => {
      if (!state.includes(action.payload)) state.push(action.payload)
    },
    removeFavorite: (state, action) => {
      return state.filter(id => id !== action.payload)
    },
  },
})

export const { addFavorite, removeFavorite } = favoritesSlices.actions
export default favoritesSlices.reducer
