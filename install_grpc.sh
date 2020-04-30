#!/bin/bash

set -e

function build_third_party() {
    cd $1/
    bash build.sh
    cd -
    echo 'Build '$1' successed.'
}

function prepare() {
    build_third_party zlib
    build_third_party protobuf
    build_third_party gflags
    build_third_party abseil-cpp
    build_third_party cares
    build_third_party benchmark
    build_third_party grpc
    echo 'grpc install Succeed!'
}

prepare
