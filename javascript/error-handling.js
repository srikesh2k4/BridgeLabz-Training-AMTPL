export const risky = () => {
  if (Math.random() > 0.5) throw new Error("Failed")
  return "Success"
}
