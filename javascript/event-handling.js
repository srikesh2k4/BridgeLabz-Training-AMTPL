export const handleClick = event => event.target.value
export const handleMouseOver = event => event.target.style.backgroundColor = 'yellow'
export const handleKeyPress = event => event.key === 'Enter' ? 'Enter key pressed' : 'Other key pressed'    
export const handleFormSubmit = event => {
  event.preventDefault()
  return 'Form submitted'
}
export const handleFocus = event => event.target.style.border = '2px solid blue'
export const handleBlur = event => event.target.style.border = '1px solid gray'