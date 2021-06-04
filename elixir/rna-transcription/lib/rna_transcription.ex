defmodule RnaTranscription do
  @doc """
  Transcribes a character list representing DNA nucleotides to RNA

  ## Examples

  iex> RnaTranscription.to_rna('ACTG')
  'UGAC'
  """
  @spec to_rna([char]) :: [char]
  def to_rna(dna) do
    dna
    |> Enum.map(fn c ->
      char = List.to_string([c])

      cond do
        char === "G" -> "C"
        char === "C" -> "G"
        char === "T" -> "A"
        char === "A" -> "U"
      end
    end)
    |> Enum.join("")
    |> String.to_charlist()
  end
end
