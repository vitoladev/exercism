defmodule Raindrops do
  @doc """
  Returns a string based on raindrop factors.

  - If the number contains 3 as a prime factor, output 'Pling'.
  - If the number contains 5 as a prime factor, output 'Plang'.
  - If the number contains 7 as a prime factor, output 'Plong'.
  - If the number does not contain 3, 5, or 7 as a prime factor,
    just pass the number's digits straight through.
  """
  @spec convert(pos_integer) :: String.t()
  def convert(number) do
    drops = [
      {3, "Pling"},
      {5, "Plang"},
      {7, "Plong"}
    ]

    raindrop =
      Enum.filter(drops, fn {factor, _} -> rem(number, factor) == 0 end)
      |> Enum.map(fn {_, sound} -> sound end)
      |> Enum.join("")

    if String.length(raindrop) == 0 do
      Integer.to_string(number)
    else
      raindrop
    end
  end
end
