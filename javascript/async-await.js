export const fetchAsync = async () => {
  const result = await Promise.resolve("Async Data")
  return result
}
