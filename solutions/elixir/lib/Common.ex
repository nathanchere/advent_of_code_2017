defmodule Common do

  @inputPath '../../challenges'

  def get_input(filename) do
    File.read!("#{@inputPath}/#{filename}")
  end

  def stream_input(filename) do
      File.stream!("#{@inputPath}/#{filename}")
  end
end
