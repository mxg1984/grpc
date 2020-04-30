set -e
base_dir=$(cd "$(dirname "$0")";pwd)
cd $base_dir/1.28.0

rm build -rf
mkdir build
pushd build

echo $PWD
cmake -DgRPC_INSTALL=ON -DgRPC_BUILD_TESTS=OFF \
      -DCMAKE_BUILD_TYPE=Release \
      -DBUILD_SHARED_LIBS=ON \
      -DCMAKE_INSTALL_PREFIX=/usr/local \
      -DgRPC_PROTOBUF_PROVIDER=package \
      -DgRPC_ZLIB_PROVIDER=package \
      -DgRPC_CARES_PROVIDER=package \
      -DgRPC_SSL_PROVIDER=package \
      -DgRPC_GFLAGS_PROVIDER=package \
      -DgRPC_BENCHMARK_PROVIDER=package \
      -DgRPC_ABSL_PROVIDER=package ..
      
make -j4
make install

popd
rm build -rf

