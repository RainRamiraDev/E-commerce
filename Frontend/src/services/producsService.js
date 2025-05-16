/**
 * Este archivo define funciones para interactuar con la API de productos usando axios.
 * 
 * - Se importa la instancia de axios previamente configurada desde `axiosConfig`.
 *   Esto permite reutilizar una configuración común para todas las peticiones HTTP (como baseURL, headers, timeout).
 * 
 * - `getProductById(id)`:
 *   - Recibe un ID como parámetro.
 *   - Realiza una petición GET a la URL `/[id]`, por ejemplo `/5`, lo que se traduce en una llamada completa como:
 *     `https://fakestoreapi.com/products/5`
 *   - Retorna la promesa que resuelve la respuesta del servidor.
 * 
 * - `getAllProducts()`:
 *   - Realiza una petición GET a la URL `/`, es decir, al endpoint base `https://fakestoreapi.com/products`.
 *   - Este endpoint devuelve un listado con todos los productos.
 * 
 * Este enfoque separa claramente la lógica de comunicación con la API del resto de la aplicación,
 * lo cual mejora la mantenibilidad y escalabilidad del código.
 */

import axiosInstance from '../config/axiosConfig';

export const getProductById = (id) => {
  return axiosInstance.get(`/${id}`);
};

export const getAllProducts = () => {
  return axiosInstance.get('/');
};
