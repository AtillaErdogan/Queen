import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
//Global bir css dosyası
import './index.css'
import App from './App.tsx'

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <App />
  </StrictMode>,
)
